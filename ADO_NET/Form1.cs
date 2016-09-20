using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ADO_NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox3.Visible = false;
            label4.Text = "Closed";
        }

        private void button_connexion_Click(object sender, EventArgs e)
        {
            // SqlConnection sqlConnect;
            // sqlConnect = new SqlConnection();
            // sqlConnect.ConnectionString = " server =" + textBox1 +"; database = " + textBox2 +";Integrated security = true";

            try
            {
                SqlConnection connect = new SqlConnection("server =" + textBox1.Text + "; database = " + textBox2.Text + ";Integrated security = true");
                connect.Open();
                label4.Text = connect.State.ToString();
            }
            catch(Exception ex)
            {
                
                textBox3.Visible = true;
                textBox3.Text = ex.Message;
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_deconnexion_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection("server =" + textBox1.Text + "; database = " + textBox2.Text + ";Integrated security = true");
            connect.Close();
            label4.Text = connect.State.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
