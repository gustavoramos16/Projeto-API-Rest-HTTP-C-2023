using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ClassLibrary1
{
    class database
    {
        string caminho = "SERVER=localhost;DATABASE=empresa;UID=root;PASSWORD=;";
        public MySqlConnector.MySqlConnection conexao;

        public database()
        {
            MySqlConnection connection = new MySqlConnection(caminho);
            MySqlCommand command = connection.CreateCommand();
            connection.Open();

            connection.Close();
        }
    }
}
