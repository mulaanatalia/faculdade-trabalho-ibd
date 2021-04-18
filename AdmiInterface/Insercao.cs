using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AdmiInterface
{
    public class Insercao
    {
        private Conexao conexao;
        private MySqlCommand comando;
        private string mensagem;
        public Insercao()
        {
            conexao = new Conexao();
            comando = new MySqlCommand();
        }

        public string Mensagem { get => mensagem;}

        public void estudante(int cod, string pNome, string uNome,
            char genero, string dataNascimento, string estadoC, string nacionalidade,
            string naturalidade,string dataIngresso , string email, int []telef, string []morada, int codCurso)
        {
            comando.CommandText =("insert into estudante values (@codigoEstudante, @pNome, @uNome," +
                " @genero, @dataNascimento, @estadoC, @nacionalidade," +
                " @naturalidade, @dataIngresso, @documento, @nrDocumento," +
                " @email, @telef1, @telef2, @cidade, @bairro, @quarteirao," +
                " @nrCasa, @codCurso);");
            comando.Parameters.AddWithValue("@codEstudante", cod);
            comando.Parameters.AddWithValue("@pNome", pNome);
            comando.Parameters.AddWithValue("@uNome", uNome);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@dataNascimento", dataNascimento);
            comando.Parameters.AddWithValue("@estadoC", estadoC);
            comando.Parameters.AddWithValue("@nacionalidade", nacionalidade);
            comando.Parameters.AddWithValue("@naturalidade", naturalidade);
            comando.Parameters.AddWithValue("@dataIngresso", dataIngresso);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@telef1", telef[0]);
            comando.Parameters.AddWithValue("@telef2", telef[1]);
            comando.Parameters.AddWithValue("@cidade", morada[0]);
            comando.Parameters.AddWithValue("@cidade", morada[1]);
            comando.Parameters.AddWithValue("@cidade", morada[2]);
            comando.Parameters.AddWithValue("@cidade", morada[3]);
            comando.Parameters.AddWithValue("@codCurso", codCurso);
            try
            {
                comando.Connection = conexao.conectar();
                comando.ExecuteNonQuery();
                conexao.desconectar();
                mensagem = "estudante cadastrado";
            }
            catch (MySqlException)
            {
                mensagem = "Erro ao cadastrar estudante";
            }

        }
    }
}
