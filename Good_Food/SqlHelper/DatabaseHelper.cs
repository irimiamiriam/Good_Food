using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Food.SqlHelper
{
   class DatabaseHelper
    {
        private static readonly  string _connectionstring = Access.GetConnectionString();
        private static readonly string _meniupath = Access.GetMeniuPath();
        private static readonly string _excelpath = Access.GetExcelPath();
        
        public static void IntroducereMeniu()
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string deleteCommandText = "DELETE FROM Meniu";
                using (SqlCommand deletecmd = new SqlCommand(deleteCommandText, con))
                { deletecmd.ExecuteNonQuery(); }

                using (StreamReader reader = new StreamReader(_meniupath))
                {
                    reader.ReadLine();
                    while (reader.Peek() > 0)
                    { 
                        string line = reader.ReadLine();
                       
                        var split = line.Split(';');
                        if (split.Length == 7)
                        {
                            string cmdText = "Insert into Meniu values (@id, @nume, @descriere, @pret, @kcal, @fel)";
                            using (SqlCommand cmd = new SqlCommand(cmdText, con))
                            {

                                int id = Convert.ToInt32(split[0]);
                                int p = Convert.ToInt32(split[3]);
                                int kCal = Convert.ToInt32(split[4]);
                                int f = Convert.ToInt32(split[5]);
                                cmd.Parameters.AddWithValue("@id", id);
                                cmd.Parameters.AddWithValue("@nume", split[1]);
                                cmd.Parameters.AddWithValue("@descriere", split[2]);
                                cmd.Parameters.AddWithValue("@pret", p);
                                cmd.Parameters.AddWithValue("@kcal", kCal);
                                cmd.Parameters.AddWithValue("@fel", f);
                                cmd.ExecuteNonQuery();
                            }
                        }
                        
                    }
                }
            }
        }

        public static void DeleteClienti()
        {   using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string deleteCommandText = "DELETE FROM Clienti";
                string deleteComenziCommandText = "DELETE FROM Comenzi";
                string deleteSubComenziCommandText = "DELETE FROM Subcomenzi";
                using (SqlCommand deletecmd = new SqlCommand(deleteCommandText, con))
                { deletecmd.ExecuteNonQuery(); }
                using (SqlCommand deletecmd = new SqlCommand(deleteComenziCommandText, con))
                { deletecmd.ExecuteNonQuery(); }
                using (SqlCommand deletecmd = new SqlCommand(deleteSubComenziCommandText, con))
                { deletecmd.ExecuteNonQuery(); }
                SqlCommand cmd1 = new SqlCommand("DBCC CHECKIDENT('Clienti', RESEED, 0)", con);
                SqlCommand cmd2 = new SqlCommand("DBCC CHECKIDENT('Comenzi', RESEED, 0)", con);
                SqlCommand cmd3 = new SqlCommand("DBCC CHECKIDENT('Subcomenzi', RESEED, 0)", con);
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();


            }
        }
        

        public static int CheckUser(string adress, string pass)
        {
            int count = 0;
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT id_client FROM Clienti WHERE email=@adresa AND parola=@password",con))
                {
                    cmd.Parameters.AddWithValue("@adresa", adress);
                    cmd.Parameters.AddWithValue("@password", pass);
                    count= (int)cmd.ExecuteScalar();
                }
            }
            return count;
        }

        public static bool CheckEmail(string adress)
        {
            int count = 0;
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Clienti WHERE email=@adresa", con))
                {
                    cmd.Parameters.AddWithValue("@adresa", adress);
                    count = (int)cmd.ExecuteScalar();
                }
            }
            return count > 0;
        }
        public static void CreateUser(string nume,string prenume, string adres, string pass, string adresemail)
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "INSERT INTO Clienti (parola, nume, prenume,adresa,email,kcal_zilnice) VALUES (@pas,@num, @prenum, @adr,@adre, @kcal)";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@adr", adres);
                    cmd.Parameters.AddWithValue("@pas", pass);
                    cmd.Parameters.AddWithValue("@prenum", prenume);
                    cmd.Parameters.AddWithValue("@num", nume);
                    cmd.Parameters.AddWithValue("@adre", adresemail);
                    cmd.Parameters.AddWithValue("@kcal", 2000);
                    cmd.ExecuteNonQuery();
                }
            }
            
        }

        public static DataTable MeniuDT()
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {   conn.Open();
                string cmdText = "Select * from Meniu";
                using (SqlCommand cmd =new SqlCommand(cmdText, conn))
                {
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public  static void UpdateKcal(int cal, int idClient)
        {
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                string cmdText = "UPDATE Clienti SET  kcal_zilnice = @kcal WHERE id_client=@id";
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("@kcal", cal);
                    cmd.Parameters.AddWithValue("@id", idClient);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static int AddInComanda(int idClient)
        {
            int idComanda;
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                string cmdText = "Insert into Comenzi (id_client, data_comanda) values (@id, @data)";
                string cmd2Text = "Select id_comanda from Comenzi where id_client=@id";
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    DateTime dateTime = DateTime.Now;
                    cmd.Parameters.AddWithValue("@id", idClient);
                    cmd.Parameters.AddWithValue("@data", dateTime);
                    cmd.ExecuteNonQuery();
                }
                using (SqlCommand cmd2 = new SqlCommand(cmd2Text, conn))
                {
                   
                    cmd2.Parameters.AddWithValue("@id", idClient);
                   SqlDataReader rd = cmd2.ExecuteReader();
                   
                        string s = rd["id_comanda"].ToString();

                    
                    idComanda = Convert.ToInt32(rd["id_comanda"]);
                    }
            }
            return idComanda;
        }

        public static void AddInSubComenzi(DataGridViewRow row, int idComanda)
        {
            string produs = row.Cells[1].Value.ToString();
            int cantitate = Convert.ToInt32(row.Cells[4].Value);
            int idprod;
            using (SqlConnection conn = new SqlConnection(_connectionstring))
            {
                conn.Open();
                string cmdText = "Insert into Subcomenzi (id_comanda, id_produs, cantitate ) values (@idCom, @idProd, @cant)";
                string cmd2Text = "Select id_produs from Meniu where denumire_produs = @produs";
                using (SqlCommand cmd2 = new SqlCommand(cmd2Text, conn))
                {
                    cmd2.Parameters.AddWithValue("@produs", produs);
                    idprod=  cmd2.ExecuteNonQuery();
                }
                using (SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("@idCom", idComanda);
                    cmd.Parameters.AddWithValue("@idProd", idprod);
                    cmd.Parameters.AddWithValue("@cant", cantitate);
                    cmd.ExecuteNonQuery();
                }
            }
        }



    }
}
