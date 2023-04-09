using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Database.SQLServer.ADO
{
    public class Paciente
    {
        public static List<Models.Paciente> Get (string connectionString)
        {
            List<Models.Paciente> pacientes = new List<Models.Paciente>(); // Cria uma lista de pacientes

            using (SqlConnection conn = new SqlConnection()) // Cria uma conexão com o banco de dados
            {
                conn.ConnectionString = connectionString; // Pega a string de conexão do arquivo de configurações
                conn.Open(); // Abre a conexão com o banco de dados

                //select codigo, nome, email from paciente;
                string commandText = "select codigo, nome, email from paciente;";

                using (SqlCommand cmd = new SqlCommand(commandText, conn)) // Cria um comando SQL
                {
                    using (SqlDataReader dr = cmd.ExecuteReader()) // Executa o comando SQL e retorna um leitor de dados
                    {
                        while (dr.Read()) // Enquanto houver dados para ler
                        {
                            Models.Paciente paciente = new Models.Paciente();
                            paciente.Codigo = (int)dr["codigo"];
                            paciente.Nome = (string)dr["nome"];
                            paciente.Email = (string)dr["email"];

                            pacientes.Add(paciente); // Adiciona o paciente na lista de pacientes
                        }
                    }
                }
            }
            return pacientes;
        }

        public static Models.Paciente GetById (int id, string connectionString)
        {
            Models.Paciente paciente = new Models.Paciente();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select codigo, nome, email from paciente where codigo = @codigo;";
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = id;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            paciente.Codigo = (int)dr["codigo"];
                            paciente.Nome = (string)dr["nome"];
                            paciente.Email = (string)dr["email"];
                        }
                    }
                }
            }
            return paciente;
        }

        public static void Add (Models.Paciente paciente, string connectionString)
        {
            using (SqlConnection conn = new SqlConnection()) // Cria uma conexão com o banco de dados
            {
                conn.ConnectionString = connectionString; // Pega a string de conexão do arquivo de configurações
                conn.Open(); // Abre a conexão com o banco de dados

                using (SqlCommand cmd = new SqlCommand()) // Cria um comando SQL
                {
                    cmd.Connection = conn; // Informa a conexão que o comando SQL deve usar
                    cmd.CommandText = "insert into paciente (nome, email) values (@nome, @email); select convert (int, @@identity) as Codigo;"; // Informa o comando SQL que deve ser executado, com parâmetros
                                                                                                                                           //cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = paciente.Codigo; 
                    cmd.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = paciente.Nome;
                    cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar)).Value = paciente.Email;

                    paciente.Codigo = (int)cmd.ExecuteScalar();
                }
            }
        }

        public static int Update (int id, Models.Paciente paciente, string connectionString)
        {
            int linhasAfetadas = 0;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "update paciente set nome = @nome, email = @email where codigo = @codigo;";
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = paciente.Codigo;
                    cmd.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = paciente.Nome;
                    cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar)).Value = paciente.Email;

                   linhasAfetadas = cmd.ExecuteNonQuery();
                }
            }
            return linhasAfetadas;
        }

        public static int Delete(int id, string connectionString)
        {
            int linhaAfetadas = 0;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from paciente where codigo = @codigo;";

                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = id;

                    linhaAfetadas = cmd.ExecuteNonQuery();
                }
            }
            return linhaAfetadas;
        }
    }
}
