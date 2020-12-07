using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Asuma
{
    public class BD
    {
        private MySqlConnection connection;
        private string MyConString = "SERVER=ingreq2021-mysql.cobadwnzalab.eu-central-1.rds.amazonaws.com; DATABASE=apsgrupo05; UID=grupo05; PASSWORD=angelsilva2021;";
        public BD() {
            connection = new MySqlConnection(MyConString);
            connection.Open();
        }

        public MySqlDataReader Query(string query)
        {
            var cmd = new MySqlCommand(query, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public void closeBD()
        {
            connection.Close();
        }
            
    }
}
