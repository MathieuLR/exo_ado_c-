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

namespace exo_3_recheche_combo_list
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         public string DetailCommande ()
        {

            string fonction = " select NUMCOM, DATCOM, OBSCOM from stg07.ENTCOM join stg07.FOURNIS on stg07.ENTCOM.NUMFOU = stg07.FOURNIS.NUMFOU where NOMFOU  = '";
            return fonction;
        }

        public string CommandeALL ()
        {
            string superfonction = "select NUMCOM, DATCOM,OBSCOM from stg07.ENTCOM ";
            return superfonction;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataReader resultatrequete;
            SqlConnection connect = null;
            SqlCommand requete = null;
            try
            {
                connect = new SqlConnection("server=;integrated security = true;database = papyrusnormal");
                connect.Open();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            try
            {
                requete = new SqlCommand("select NOMFOU from stg07.FOURNIS ", connect);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            resultatrequete = requete.ExecuteReader();
            List<string> nomfourni = new List<string>();

            while (resultatrequete.Read())
            {
                //nomfourni.Add(resultatrequete["NOMFOU"].ToString());
                comboBox1.Items.Add(resultatrequete["NOMFOU"].ToString());
            }




            //for (int i = 0; i < nomfourni.Count; i++)
            //{
            //    comboBox1.Items.Add(nomfourni[i]);
            //}


            comboBox1.Items.Insert(0, "Tous");


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_commande.Items.Clear();

            SqlDataReader resultatrequete;
            SqlConnection connect = null;
            SqlCommand requete = null;
            try
            {
                connect = new SqlConnection("server=;integrated security = true;database = papyrusnormal");
                connect.Open();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }

            if (comboBox1.SelectedIndex == 0)
            {
                try
                {
                    requete = new SqlCommand(CommandeALL(), connect);
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }

                resultatrequete = requete.ExecuteReader();

                while (resultatrequete.Read())
                {

                    listBox_commande.Items.Add(resultatrequete["NUMCOM"].ToString());
                    listBox_commande.Items.Add(resultatrequete["DATCOM"].ToString());
                    listBox_commande.Items.Add(resultatrequete["OBSCOM"].ToString());

                }
                connect.Close();
            }
            else
            {

                try
                {
                   
                    requete = new SqlCommand(DetailCommande() + comboBox1.Text + "' ", connect);
                   
                    //requete = new SqlCommand("select NUMCOM, DATCOM,OBSCOM from stg07.ENTCOM join stg07.FOURNIS on stg07.ENTCOM.NUMFOU = stg07.FOURNIS.NUMFOU where NOMFOU ='" + comboBox1.Text + "' ", connect);
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }

                resultatrequete = requete.ExecuteReader();

                while (resultatrequete.Read())
                {

                    listBox_commande.Items.Add(resultatrequete["NUMCOM"].ToString());
                    listBox_commande.Items.Add(resultatrequete["DATCOM"].ToString());
                    listBox_commande.Items.Add(resultatrequete["OBSCOM"].ToString());

                }



                connect.Close();
            
        }
    }

    private void button_quitter_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}

}
