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
using System.Text.RegularExpressions;


namespace exo_2_recherche
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_cherchez_Click(object sender, EventArgs e)
        {

            SqlDataReader resultatrequete;
            SqlConnection connect = null;
            SqlCommand requete = null;



            try
            {
                connect = new SqlConnection("server = ; database = papyrusnormal  ;integrated security = true;");
                connect.Open();
            }

            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            try
            {
                requete = new SqlCommand("select NOMFOU, RUEFOU, POSFOU, VILFOU, CONFOU from stg07.FOURNIS where NUMFOU ='" + textBox_code_fournisseur.Text + "' ", connect);

            }
            catch
            {
                if (textBox_code_fournisseur.Text.Length == 0)
                {
                    MessageBox.Show("NUMFOU invalide");
                }



            }

            try
            {
                resultatrequete = requete.ExecuteReader();



                if (resultatrequete.Read())
                {

                    textBox_nom.Text = resultatrequete["NOMFOU"].ToString();
                    textBox_adresse.Text = resultatrequete["RUEFOU"].ToString();
                    textBox_code_postal.Text = resultatrequete["POSFOU"].ToString();
                    textBox_ville.Text = resultatrequete["VILFOU"].ToString();
                    textBox_contact.Text = resultatrequete["CONFOU"].ToString();

                }
                else
                {
                    MessageBox.Show("NUMFOU invalide");
                }


                connect.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void textBox_code_fournisseur_TextChanged(object sender, EventArgs e)
        {
            string code_fournisseur = @"^[0-9]{1,4}$";
            if (!Regex.IsMatch(textBox_code_fournisseur.Text, code_fournisseur))
            {
                textBox_code_fournisseur.BackColor = Color.Red;

            }
            else
            {
                textBox_code_fournisseur.BackColor = Color.GreenYellow;
            }
        }
    }
}
