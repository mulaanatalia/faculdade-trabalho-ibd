using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AdmiInterface
{
    class Conexao
    {
        private MySqlConnection con = new MySqlConnection();
        public Conexao()
        {
            con.ConnectionString = "server=localhost; database=controlo_assiduidade; user=root; password=;";
        }
        public MySqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
