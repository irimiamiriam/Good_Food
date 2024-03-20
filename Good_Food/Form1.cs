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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
            DatabaseHelper.DeleteClienti();
          
        }

        private void SingUp_Click(object sender, EventArgs e)
        {
            Creare_cont_client f1 = new Creare_cont_client();
            this.Hide();
            f1.ShowDialog();
            this.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Autentificare_client f2= new Autentificare_client();
            this.Hide();
            f2.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
