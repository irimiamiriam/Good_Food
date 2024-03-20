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

namespace Good_Food
{
    public partial class Autentificare_client : Form
    {
        public Autentificare_client()
        {
            InitializeComponent();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            int idClient= DatabaseHelper.CheckUser(adresa_textBox.Text, parola_textBox.Text);
            if (idClient!=0)
            {
                Optiuni fopt = new Optiuni(idClient);
                this.Hide();
                fopt.ShowDialog();
                this.Close();
            }
            else { MessageBox.Show("Eroare autentificare!");
                parola_textBox.Text = "";
                adresa_textBox.Text = "";
            }

        }

        private void Autentificare_client_Load(object sender, EventArgs e)
        {
            adresa_textBox.Text = "miriam@gmail.com";
            parola_textBox.Text = "miriam123";
        }
    }
}
