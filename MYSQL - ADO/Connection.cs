using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYSQL___ADO
{
  class Connection
    {
        private static string connectionString = "server=btssio.dedyn.io;port=3306;Database=NJOBOJO_Bibli;Uid=NJOBOJO;password=njobojo;";
        private static MySqlConnection maConnection=new MySqlConnection(connectionString);

        public static MySqlConnection MaConnection { get => maConnection;}
    }



}
