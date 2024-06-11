using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdvVendas.br.com.Conexao
{
    internal class ConnectionFactory
    {
        public MySqlConnection GetConnection()
        {
            string Cnx = ConfigurationManager.ConnectionStrings["Iconnection"].ConnectionString;
            return new MySqlConnection(Cnx);

        }


    }
}
