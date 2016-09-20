using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace exo_4_insertion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_nom_Validating(object sender, CancelEventArgs e)
        {
            string nom_fourni = @"^[A-Za-z]+(([\- ][A-Za-z])?[A-Za-z]){1,200}$";
            if (!Regex.IsMatch(textBox_nom.Text, nom_fourni))
            {
                textBox_nom.BackColor = Color.Red;
                MessageBox.Show("Valeur d'entrée non valide [A-Z]", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_nom.Clear();
                textBox_nom.Focus();

            }
            else
            {
                textBox_nom.BackColor = Color.GreenYellow;
               
            }
        
    }

        private void textBox_adresse_Validating(object sender, CancelEventArgs e)
        {
            //string adresse_fourni = @"^[0-9]+(([\- ][A-Za-z])?[A-Za-z]){1,200}$"; 
            //string adresse_fourni = @"^[0-9a-zA-Z]{0,10}[ ,]{0,5}[A-Za-z -]{5,150}$";
            string adresse_fourni = @"^(\w|\s){5,200}$";
            if (!Regex.IsMatch(textBox_adresse.Text, adresse_fourni))
            {
                textBox_adresse.BackColor = Color.Red;
                MessageBox.Show("Valeur d'entrée non valide [A-Z]", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_adresse.Clear();
                textBox_adresse.Focus();

            }
            else
            {
                textBox_adresse.BackColor = Color.GreenYellow;
            } 
        }

        private void textBox_code_postal_Validating(object sender, CancelEventArgs e)
        {
            string code_postal_fourni = @"^[0-9]{5}$";
            if (!Regex.IsMatch(textBox_code_postal.Text, code_postal_fourni))
            {
                textBox_code_postal.BackColor = Color.Red;
                MessageBox.Show("Valeur d'entrée non valide [0-9] et uniquement cinq chiffres", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_code_postal.Clear();
                textBox_code_postal.Focus();
            }
            else
            {
                textBox_code_postal.BackColor = Color.GreenYellow;
               
            }
        }

        private void textBox_ville_Validating(object sender, CancelEventArgs e)
        {
            string ville_fourni = @"^[A-Za-z]+(([\- ][A-Za-z])?[A-Za-z]){1,200}$";
            if (!Regex.IsMatch(textBox_ville.Text, ville_fourni))
            {
                textBox_ville.BackColor = Color.Red;
                MessageBox.Show("Valeur d'entrée non valide [A-Z]", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_ville.Clear();
                textBox_ville.Focus();
            }
            else
            {
                textBox_ville.BackColor = Color.GreenYellow;
                
            }
        }

        private void textBox_contact_Validating(object sender, CancelEventArgs e)
        {
            string contact_fourni = @"^[A-Za-z]+(([\- ][A-Za-z])?[A-Za-z]){1,200}$";
            if (!Regex.IsMatch(textBox_contact.Text, contact_fourni))
            {
                textBox_contact.BackColor = Color.Red;
                MessageBox.Show("Valeur d'entrée non valide [A-Z]", "Erreur ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox_contact.Clear();
                textBox_contact.Focus();
            }
            else
            {
                textBox_contact.BackColor = Color.GreenYellow;
              
            }
        }

        private void bouton_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bouton_ajouter_Click(object sender, EventArgs e)
        {
            
            SqlConnection connect = null;
            SqlCommand requete = null;
            SqlDataReader resultatrequete;
            int numfoumax;
           

            try
            {
                connect = new SqlConnection("server= ;integrated security=true;database=papyrusnormal");
                connect.Open();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            try
            {
                requete = new SqlCommand("select MAX(NUMFOU) from stg07.FOURNIS ", connect);

            }

            
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
            numfoumax = Convert.ToInt32(requete.ExecuteScalar());






            try
            {
                connect = new SqlConnection("server= ;integrated security=true;database=papyrusnormal");
                connect.Open();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            try
            {
                requete = new SqlCommand("insert into stg07.FOURNIS(NUMFOU,NOMFOU,RUEFOU,POSFOU,VILFOU,CONFOU,SATISF) values (@NUMFOU,@NOMFOU,@RUEFOU,@POSFOU,@VILFOU,@CONFOU,@SATISF) ", connect);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }


            requete.Parameters.AddWithValue("NUMFOU", numfoumax + 1);
            requete.Parameters.AddWithValue("@NOMFOU", textBox_nom.Text);
            requete.Parameters.AddWithValue("@RUEFOU", textBox_adresse.Text);
            requete.Parameters.AddWithValue("@POSFOU", textBox_code_postal.Text);
            requete.Parameters.AddWithValue("@VILFOU", textBox_ville.Text);
            requete.Parameters.AddWithValue("@CONFOU", textBox_contact.Text);
            requete.Parameters.AddWithValue("@SATISF", trackBar_satisf.Value);

            requete.ExecuteNonQuery();
            connect.Close();

            MessageBox.Show("Ajout du fournisseur effectué");

        }

        private void textBox_adresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
