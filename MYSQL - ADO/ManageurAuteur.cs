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
            Auteur unAuteur = new Auteur();
            unAuteur.Num = Convert.ToInt16(monReader["num"]);
            unAuteur.Nom = monReader["nom"] == DBNull.Value ? "" : monReader["nom"] as string;
            unAuteur.Prenom = monReader["prenom"] == DBNull.Value ? "" : monReader["prenom"] as string;
            unAuteur.Nationalite = monReader["nationalite"] == DBNull.Value ? "" : monReader["nationalite"] as string;
            return unAuteur;
        }

        public static List<Auteur> DonneAuteurs()
        {
            List<Auteur> lesAuteurs = new List<Auteur>();

            using (MySqlConnection connection = Connection.MaConnection)
            {
                connection.Open();

                maRequete = connection.CreateCommand();
                maRequete.CommandText = "select * from auteur order by nom";
                monReader = maRequete.ExecuteReader();

                while (monReader.Read())
                {
                    Auteur unAuteur = ManageurAuteur.DonneAuteurDuReader(monReader);
                    lesAuteurs.Add(unAuteur);
                }
            } 

            return lesAuteurs;
        }


        public static Auteur DonneAuteurParId(int id)
        {
            Auteur unAuteur = new Auteur();
            return unAuteur;
        }

        public static bool ModifierAuteur(Auteur auteur)
        {
            bool resultat=true;
            return resultat;
        }

        public static bool AjouterAuteur(Auteur a)
        {
            MySqlCommand maRequete = Connection.MaConnection.CreateCommand();
            bool reponse = false;

            // Use INSERT INTO instead of UPDATE
            maRequete.CommandText = "INSERT INTO auteur (nom, prenom, nationalite) VALUES (@paramNom, @paramPrenom, @paramNation)";
            maRequete.Parameters.AddWithValue("@paramNom", a.Nom);
            maRequete.Parameters.AddWithValue("@paramPrenom", a.Prenom);
            maRequete.Parameters.AddWithValue("@paramNation", a.Nationalite);

            try
            {
                Connection.MaConnection.Open();
                int resultat = maRequete.ExecuteNonQuery();

                if (resultat > 0)
                {
                    MessageBox.Show("L'auteur a bien été ajouté");
                }
                else
                {
                    MessageBox.Show("Une erreur s'est produite, l'auteur n'a pas été ajouté");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Une exception s'est produite : " + ex.Message);
            }
            finally
            {
                Connection.MaConnection.Close();
            }

            return true;
        }


        public static bool SupprimerAuteur(Auteur a)
        {
            bool resultat = true;
            return resultat;
        }
    }
}
