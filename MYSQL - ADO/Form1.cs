using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MYSQL_ADO;

namespace MYSQL___ADO
{
    public partial class Form1 : Form
    {
       List<Auteur> lesAuteurs = new List<Auteur>();

        private MySqlCommand maRequete;
        private MySqlDataReader monReader;

        public Form1()
        {
            InitializeComponent();
            RemplirListe();

        }

        public Form1(bool v, Auteur auteurSelectionne)
        {
        }

        private void RemplirListe()
        {
            try 
            {
                lesAuteurs = ManageurAuteur.DonneAuteurs();
                bs.DataSource= lesAuteurs;
            }
            catch (Exception ex)
            {

                MessageBox.Show("erreur :" + ex.Message);
            }finally {
                
          
            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //afficher
        private void button1_Click(object sender, EventArgs e)
        {

            Auteur AuteurSelectionne = new Auteur();
            DataGridViewRow ligne =  dgv_ListeAuteurs.SelectedRows[0];
            AuteurSelectionne=ligne.DataBoundItem as Auteur;
            if(AuteurSelectionne != null )
            {
                Form1 frm = new Form1(false,AuteurSelectionne);
                frm.ShowDialog();
            }

        }
        //modifier
        private void button1_Click_1(object sender, EventArgs e)
        {
            Auteur auteurSelectionne = dgv_ListeAuteurs.SelectedRows[0].DataBoundItem as Auteur;

            if (auteurSelectionne != null)
            {
                FicheAuteur frm = new FicheAuteur(true, auteurSelectionne);
                frm.ShowDialog();
                RemplirListe();
                dgv_ListeAuteurs.Refresh();
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            int element = Convert.ToInt16(dgv_ListeAuteurs.SelectedRows[0].Cells[0].Value.ToString());
            FicheAuteur frm = new FicheAuteur(true, element);
            frm.Show();
            RemplirListe();
            dgv_ListeAuteurs.Refresh();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
