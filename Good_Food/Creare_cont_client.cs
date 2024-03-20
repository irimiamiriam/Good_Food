using Good_Food.SqlHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Good_Food
{
    public partial class Creare_cont_client : Form
    {
        public Creare_cont_client()
        {
            InitializeComponent();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            string[] parts = email.Split('@');
            if (parts.Length != 2)
            {
                return false; 
            }

            string localPart = parts[0];
            string domainPart = parts[1];
            if (string.IsNullOrWhiteSpace(localPart) || string.IsNullOrWhiteSpace(domainPart))
            {
                return false; 
            }

           
            foreach (char c in localPart)
            {
                if (!char.IsLetterOrDigit(c) && c != '.' && c != '_' && c != '-')
                {
                    return false; 
                }
            }

           
            if (domainPart.Length < 2 || !domainPart.Contains(".") || domainPart.Split('.').Length != 2 || domainPart.EndsWith(".") || domainPart.StartsWith("."))
            {
                return false; 
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(parola_textBox.Text==verparola_textBox.Text&&IsValidEmail(email_textBox.Text)) {
                if (DatabaseHelper.CheckEmail(email_textBox.Text) == false)
                {
                    DatabaseHelper.CreateUser(nume_textBox.Text,prenume_textBox.Text, adresa_textBox.Text, parola_textBox.Text, email_textBox.Text);
                    this.Close();
                }else { MessageBox.Show("Exista deja un cont cu aceasta adresa de email");
                    email_textBox.Text = "";
                }
            }
        }

        private void Creare_cont_client_Load(object sender, EventArgs e)
        {
            nume_textBox.Text = "Irimia";
            prenume_textBox.Text = "Miriam";
            adresa_textBox.Text = "Cudalbi";
            parola_textBox.Text = "miriam123";
            verparola_textBox.Text = "miriam123";
            email_textBox.Text = "miriam@gmail.com";
        }
    }
}
