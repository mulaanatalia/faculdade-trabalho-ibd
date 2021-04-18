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

        public string Mensagem { get => mensagem; }
        public void disciplina(string cod, string nome, int cargaHoraria,
            string estatuto, int credito)
        {
            comando.CommandText = "insert into disciplina values" +
                "(@cod, @nome, @cargaHoraria, @estatuto, @creditos)";
            comando.Parameters.AddWithValue("@cod", cod);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@cargaHoraria", cargaHoraria);
            comando.Parameters.AddWithValue("@estatuto", estatuto);
            comando.Parameters.AddWithValue("@creditos", credito);
            try
            {
                comando.Connection = conexao.conectar();
                comando.ExecuteNonQuery();
                conexao.desconectar();
                mensagem = "Disciplina Cadastrada";
            }
            catch (MySqlException)
            {
                mensagem = "Erro ao cadastrar disciplina";
            }
            comando.Parameters.Clear();

        }
        public void curso(string cod, string nome, int duracao, string desc)
        {
            comando.CommandText = "insert into curso values " +
                "(@codigo, @nome, @duracao, @descricao)";
            comando.Parameters.AddWithValue("@codigo",cod);
            comando.Parameters.AddWithValue("@nome", nome);
            comando.Parameters.AddWithValue("@duracao", duracao);
            comando.Parameters.AddWithValue("@descricao", desc);
            try
            {
                comando.Connection = conexao.conectar();
                comando.ExecuteNonQuery();
                conexao.desconectar();
                mensagem = "Curso Cadastrado";
            }
            catch (MySqlException)
            {
                mensagem = "Erro ao cadastrar Curso";
            }
            comando.Parameters.Clear();
        }
        public void estudante(int cod, string pNome, string uNome,
            char genero, string dataNascimento, string estadoC, string nacionalidade,
            string naturalidade, string dataIngresso, string identidade, string nrId, string email, int[] telef, string[] morada, string codCurso)
        {
            comando.CommandText = ("insert into estudante values (@codigoEstudante, @pNome, @uNome," +
                " @genero, @dataNascimento, @estadoC, @nacionalidade," +
                " @naturalidade, @dataIngresso, @identidade, @numeroIdentidade @documento, @nrDocumento," +
                " @email, @telef1, @telef2, @cidade, @localidade, @bairro, @quarteirao," +
                " @nrCasa, @codCurso);");
            comando.Parameters.AddWithValue("@codEstudante", cod);
            comando.Parameters.AddWithValue("@pNome", pNome);
            comando.Parameters.AddWithValue("@uNome", uNome);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@dataNascimento", dataNascimento);
            comando.Parameters.AddWithValue("@estadoC", estadoC);
            comando.Parameters.AddWithValue("@nacionalidade", nacionalidade);
            comando.Parameters.AddWithValue("@naturalidade", naturalidade);
            comando.Parameters.AddWithValue("@identidade", identidade);
            comando.Parameters.AddWithValue("@numeroIdentidade", nrId);
            comando.Parameters.AddWithValue("@dataIngresso", dataIngresso);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@telef1", telef[0]);
            comando.Parameters.AddWithValue("@telef2", telef[1]);
            comando.Parameters.AddWithValue("@cidade", morada[0]);
            comando.Parameters.AddWithValue("@localidade", morada[1]);
            comando.Parameters.AddWithValue("@bairro", morada[2]);
            comando.Parameters.AddWithValue("@quarteirao", morada[3]);
            comando.Parameters.AddWithValue("@nrCasa", morada[4]);
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
            comando.Parameters.Clear();
        }
        public void docente(int cod, string pNome, string uNome,
            char genero, string dataNascimento, string estadoC, string nacionalidade,
            string naturalidade, string dataIngresso, string identidade, string nrId, string email, int[] telef, string[] morada,
            string formacao, string codDisciplina)
        {
            comando.CommandText = ("insert into estudante values (@codigoEstudante, @pNome, @uNome," +
                " @genero, @dataNascimento, @estadoC, @nacionalidade," +
                " @naturalidade, @dataIngresso, @identidade, @numeroIdentidade @documento, @nrDocumento," +
                " @email, @telef1, @telef2, @cidade, @localidade, @bairro, @quarteirao," +
                " @nrCasa, @formacao, @codDisciplina);");
            comando.Parameters.AddWithValue("@codEstudante", cod);
            comando.Parameters.AddWithValue("@pNome", pNome);
            comando.Parameters.AddWithValue("@uNome", uNome);
            comando.Parameters.AddWithValue("@genero", genero);
            comando.Parameters.AddWithValue("@dataNascimento", dataNascimento);
            comando.Parameters.AddWithValue("@estadoC", estadoC);
            comando.Parameters.AddWithValue("@nacionalidade", nacionalidade);
            comando.Parameters.AddWithValue("@naturalidade", naturalidade);
            comando.Parameters.AddWithValue("@identidade", identidade);
            comando.Parameters.AddWithValue("@numeroIdentidade", nrId);
            comando.Parameters.AddWithValue("@dataIngresso", dataIngresso);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@telef1", telef[0]);
            comando.Parameters.AddWithValue("@telef2", telef[1]);
            comando.Parameters.AddWithValue("@cidade", morada[0]);
            comando.Parameters.AddWithValue("@localidade", morada[1]);
            comando.Parameters.AddWithValue("@bairro", morada[2]);
            comando.Parameters.AddWithValue("@quarteirao", morada[3]);
            comando.Parameters.AddWithValue("@nrCasa", morada[4]);
            comando.Parameters.AddWithValue("@formacao", formacao);
            comando.Parameters.AddWithValue("@codDisciplina", codDisciplina);
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
            comando.Parameters.Clear();
        }

    }
    }
