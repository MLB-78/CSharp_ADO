using MySql.Data.MySqlClient;
using MYSQL_ADO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MYSQL___ADO
{
    public partial class FicheAuteur : Form
    {

        private BindingSource bs = new BindingSource();
        private int numAuteur;
        private bool v;
        private int element;
        Auteur AuteurCourant = new Auteur();

        public FicheAuteur(bool modification,Auteur monAuteur=null)
        {
            InitializeComponent();
            try
            {
                if(monAuteur!=null)
                {
                    bs.DataSource = monAuteur;
                    AuteurCourant =monAuteur;
                }   
                bs.DataSource=AuteurCourant;
               
                if (modification == false) {

                    textNom.Enabled = false;
                    textPrenom.Enabled = false;
                    textNationalite.Enabled = false;

                
                }
                // Associez le BindingSource aux contrôles
                textNom.DataBindings.Add("Text", bs, "Nom");
                textPrenom.DataBindings.Add("Text", bs, "Prenom");
                textNationalite.DataBindings.Add("Text", bs, "Nationalite");
            }
            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            }
           
        }

        public FicheAuteur(bool v, int element)
        {
            this.v = v;
            this.element = element;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FicheAuteur_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            if (ContoleSaisies() == true)
            {
                try
                {
                    if (AuteurCourant.Num == 0)
                    {
                        AuteurCourant = bs.Current as Auteur;
                        bool reponse = ManageurAuteur.AjouterAuteur(AuteurCourant, maRequete);
                    }
                    else
                    {
                        AuteurCourant = bs.Current as Auteur;
                        bool reponse = ManageurAuteur.ModifierAuteur(AuteurCourant);
                    }
                    this.Close();
                }
                catch (Exception ex)
                {
                   
                }
               
            }
        }

     
        private bool ContoleSaisies()
        {
            bool controle = true;
            if (textNom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un nom");
                controle = false;
            }
            if (textPrenom.Text == "")
            {
                MessageBox.Show("Vous devez saisir un prénom");
                controle = false;
            }
            if (textNationalite.Text == "")
            {
                MessageBox.Show("Vous devez saisir une nationalité");
                controle = false;
            }
            return controle;
        }

        private void bs_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bs_BindingComplete(object sender, BindingCompleteEventArgs e)
        {

        }

        private void textNationalite_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
