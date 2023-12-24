using MySql.Data.MySqlClient;
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

        private int numAuteur;
        Auteur AuteurCourant = new Auteur();
        private BindingSource bs = new BindingSource();
        private bool v;
        private int element;

        public FicheAuteur(bool modification,Auteur monAuteur=null)
        {
            InitializeComponent();
            try
            {
                if(monAuteur!=null)
                {
                    AuteurCourant=monAuteur;
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
                //maRequete.CommandText = "update auteur set " +
                //"nom=@paramNom, prenom=@paramPrenom, nationalite=@paramNation where num=@paramNum";
                //maRequete.Parameters.Clear();
                //maRequete.Parameters.AddWithValue("@paramNom", textNom.Text);
                //maRequete.Parameters.AddWithValue("@paramPrenom", textPrenom.Text);
                //maRequete.Parameters.AddWithValue("@paramNation", textNationalite.Text);
                //maRequete.Parameters.AddWithValue("@paramNum", numAuteur);
                //try
                //{
                // Connection.MaConnection.Open();
                //int resultat = maRequete.ExecuteNonQuery();
                //   if (resultat > 0)
                //{
                //MessageBox.Show("L'auteur a bien été mis à jour");
                // }
                //else
                //  {
                //  MessageBox.Show("Une erreur s'est produite, l'auteur n'a pas été mis à jour");
                //}
                // }
                //   catch (Exception ex)
                // {
                //  MessageBox.Show(ex.Message);
                // }
                //  finally
                // {
                // Connection.MaConnection.Close();
                // this.Close();
                // }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
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
