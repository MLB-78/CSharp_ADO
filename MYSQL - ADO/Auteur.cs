using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYSQL___ADO
{
    public class Auteur
    {
        int num;
        string prenom = "";
        string nom = "";
        string nationalite = "";

        public global::System.String Prenom { get => prenom; set => prenom = value; }
        public global::System.String Nom { get => nom; set => nom = value; }
        public global::System.String Nationalite { get => nationalite; set => nationalite = value; }
    }
}
