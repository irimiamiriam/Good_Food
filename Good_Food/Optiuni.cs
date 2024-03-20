using Good_Food.SqlHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Good_Food
{

    public partial class Optiuni : Form
    {

        int IdClient;
        DataTable ComandaDT = new DataTable();
        public Optiuni(int idClient)
        {
            InitializeComponent();
            IdClient= idClient;


        }

        private void calculate_Click(object sender, EventArgs e)
        {
            int sum = Convert.ToInt32(varsta_textBox.Text) + Convert.ToInt32(inaltime_textBox.Text) + Convert.ToInt32(greutate_textBox.Text);
            if (sum < 250)
            {
                textBox1.Text = "1800";
            }
            else if (sum > 275)
            {
                textBox1.Text = "2500";
            }
            else textBox1.Text = "2200";
        }


        private void Optiuni_Load(object sender, EventArgs e)
        {
            grafic.Series.Add("Kcalorii");
            grafic.ChartAreas[0].AxisY.Maximum = 5000;
            totalPret.Text = "0";
            totalKcal.Text = "0";
            DatabaseHelper.IntroducereMeniu();
            dataGridView1.DataSource = DatabaseHelper.MeniuDT();

            dataGridView1.Columns.Add("Cantitate", "Cantitate");
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            {
                button.Name = "button";
                button.HeaderText = "adauga";
                button.Text = "Adauga";
                button.UseColumnTextForButtonValue = true;

                this.dataGridView1.Columns.Add(button);
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                if (i < 6)
                {
                    dataGridView1.Columns[i].ReadOnly = true;
                }
                else break;
            }
            ComandaDT.Columns.Add("Nume produs");
            ComandaDT.Columns.Add("kcal");
            ComandaDT.Columns.Add("pret");
            ComandaDT.Columns.Add("cantitate");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            necesarKcal.Text = textBox1.Text;
            necKcal.Text= textBox1.Text;
            int calorii= Convert.ToInt32(textBox1.Text);
            DatabaseHelper.UpdateKcal(calorii, IdClient);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["button"].Index)
            {
                object cantitateValue = dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                object nume = dataGridView1.Rows[e.RowIndex].Cells[3].Value;
                object Kcal = dataGridView1.Rows[e.RowIndex].Cells[6].Value;
                object pr = dataGridView1.Rows[e.RowIndex].Cells[5].Value;


                int cantitate = Convert.ToInt32(cantitateValue);
                if (cantitate < 0||cantitateValue==null) { MessageBox.Show("Cantitate negativa"); }
                else
                {
                    ComandaDT.Rows.Add(nume, Kcal, pr, cantitateValue);
                    int prevSuma = Convert.ToInt32(totalKcal.Text);
                    int sum = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[6].Value);
                    int curSuma = prevSuma + (cantitate * sum);
                    totalKcal.Text = curSuma.ToString();
                    int prevPret = Convert.ToInt32(totalPret.Text);
                    int cal = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);
                    int curPret = prevPret + (cantitate * cal);
                    totalPret.Text = curPret.ToString();
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value = null;


                    int index = -1;
                    for (int i = 0; i < grafic.Series["Kcalorii"].Points.Count; i++)
                    {
                        if (grafic.Series["Kcalorii"].Points[i].AxisLabel.ToString() == nume.ToString())
                        {
                            index = i;
                            break;
                        }
                    }
                    if (index != -1)
                    {
                        grafic.Series["Kcalorii"].Points[index].YValues[0] += cantitate * sum;


                    }
                    else
                    {
                        grafic.Series["Kcalorii"].Points.AddXY(nume.ToString(), cantitate * sum);

                    }

                }
            }
        }

        private void comand_Click(object sender, EventArgs e)
        {
            VizualizareComanda f2 = new VizualizareComanda(ComandaDT, necesarKcal.Text, totalKcal.Text, totalPret.Text, IdClient);
            this.Hide();
            f2.ShowDialog();
            this.Close();
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == GraficKcal)
            {
                grafic.Invalidate();
            }
        }

        private void generate_Click(object sender, EventArgs e)
        {
            FoodItem.LoadDataFromFile();
            DataTable dt = FoodItem.GenerateCombinations(Convert.ToInt32(buget.Text));
            dataGridView2.DataSource = dt;
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            {
                col.Name = "addbtn";
                col.HeaderText = "Comanda";
                col.Text = "Comanda";
                col.UseColumnTextForButtonValue = true;
            }
            dataGridView2.Columns.Add(col);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView2.Columns["addbtn"].Index)
            {
                MessageBox.Show("Comanda finalizata!");
            }
        }
    }
}
