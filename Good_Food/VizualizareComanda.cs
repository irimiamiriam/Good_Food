using Good_Food.SqlHelper;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Good_Food
{
    public partial class VizualizareComanda : Form
    {
        int IdClient;
        public VizualizareComanda(DataTable dt, string necKcal, string totKcal, string totPret,int id)
        {
            InitializeComponent();
            IdClient = id;
            necesarKcal.Text = necKcal;
            totalKcal.Text = totKcal;
            totalPret.Text = totPret;
            dataGridView1.DataSource = dt;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            {
                btn.Name = "deletebtn";
                btn.Text = "Elimina";
                btn.HeaderText = "Elimina";
                btn.UseColumnTextForButtonValue = true;
            }
                dataGridView1.Columns.Add(btn);
        }

        private void VizualizareComanda_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == dataGridView1.Columns["deletebtn"].Index)
            {
                MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                object cantitateValue = dataGridView1.Rows[e.RowIndex].Cells[4].Value;
                int cantitate = Convert.ToInt32(cantitateValue);
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int prevSuma = Convert.ToInt32(totalKcal.Text);
                int sum = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                int curSuma = prevSuma - (cantitate * sum);
                totalKcal.Text = curSuma.ToString();
                int prevPret = Convert.ToInt32(totalPret.Text);
                int cal = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                int curPret = prevPret - (cantitate * cal);
                totalPret.Text = curPret.ToString();
                dataGridView1.Rows.Remove(row);

            }
        }

        private void buttonFinal_Click(object sender, EventArgs e)
        {
             int idcomanda= DatabaseHelper.AddInComanda(IdClient);
            for(int i=0; i<dataGridView1.Rows.Count-1; i++) { 
                DataGridViewRow row = dataGridView1.Rows[i];
                DatabaseHelper.AddInSubComenzi(row, idcomanda);
            }
            MessageBox.Show("Comanda trimisa!");

            this.Close();
        }
    }
}
