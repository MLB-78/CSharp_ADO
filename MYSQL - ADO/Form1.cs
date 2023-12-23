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
namespace MYSQL___ADO
{
    public partial class Form1 : Form
    {
       
        private MySqlCommand maRequete;
        private MySqlDataReader monReader;

        public Form1()
        {
            InitializeComponent();
            RemplirListe();

        }

        private void RemplirListe()
        {
            try 
            {
                dgv_ListeAuteurs.Rows.Clear();
                Connection.MaConnection.Open() ;
                maRequete = Connection.MaConnection.CreateCommand();
                maRequete.CommandText = "select * from auteur order by nom";
                monReader = maRequete.ExecuteReader();
                while (monReader.Read()) {

                    dgv_ListeAuteurs.Rows.Add(
                            monReader["num"].ToString(),
                            monReader["nom"].ToString(),
                            monReader["prenom"].ToString(),
                            monReader["nationalite"].ToString()

                        );
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("erreur :" + ex.Message);
            }finally {
                
                monReader.Close();
                Connection.MaConnection.Close();
            
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int element = Convert.ToInt16( dgv_ListeAuteurs.SelectedRows[0].Cells[0].Value.ToString());
            FicheAuteur frm = new FicheAuteur(false, element);          
            frm.Show();

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
