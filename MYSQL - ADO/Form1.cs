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
        private string connectionString = "server=btssio.dedyn.io;port=3306;Database=NJOBOJO_Bibli;Uid=NJOBOJO;password=njobojo;";
        private MySqlConnection maConnection;
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
                maConnection = new MySqlConnection(connectionString);
                maConnection.Open();
                maRequete = maConnection.CreateCommand();
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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
