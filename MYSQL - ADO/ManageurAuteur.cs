using MySql.Data.MySqlClient;
using MYSQL___ADO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace MYSQL_ADO
{
    public class ManageurAuteur
    {
        private static MySqlCommand maRequete;
        private static MySqlDataReader monReader;

        public static Auteur DonneAuteurDuReader(MySqlDataReader monReader)
        {
            throw new NotImplementedException();
        }

        public static List<Auteur> DonneAuteurs()
        {
            List<Auteur> auteurs = new List<Auteur>();

            try
            {
                Connection.MaConnection.Open();
                maRequete = Connection.MaConnection.CreateCommand();
                maRequete.CommandText = "select * from auteur order by nom";
                monReader = maRequete.ExecuteReader();

                while (monReader.Read())
                {
                    Auteur auteur = DonneAuteurDuReader(monReader);

                    auteurs.Add(auteur);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                monReader?.Close();
                Connection.MaConnection.Close();
            }

            return auteurs;
        }

        public static Auteur DonneAuteurParId(int id)
        {

        }

        public static bool ModifierAuteur(Auteur auteur)
        {

        }

        public static bool AjouterAuteur(Auteur a)
        {

        }

        public static bool SupprimerAuteur(Auteur a)
        {

        }
    }
}
