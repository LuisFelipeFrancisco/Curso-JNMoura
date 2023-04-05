using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class PacientesController : ApiController
    {
        // GET: api/Pacientes
        public List<Models.Paciente> Get()
        {
            List<Models.Paciente> pacientes = new List<Models.Paciente>(); // Cria uma lista de pacientes

            using (SqlConnection conn = new SqlConnection()) // Cria uma conexão com o banco de dados
            {
                conn.ConnectionString = Configurations.SQLServer.getConnectionString(); // Pega a string de conexão do arquivo de configurações
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

        // GET: api/Pacientes/5
        public IHttpActionResult Get(int id) 
        {
            Models.Paciente paciente = new Models.Paciente();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Configurations.SQLServer.getConnectionString();
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

            if (paciente.Codigo == 0)
                return NotFound();

            return Ok(paciente);
        }

        // POST: api/Pacientes
        public IHttpActionResult Post(Models.Paciente paciente) // Recebe um paciente
        {
            try
            {
                if (string.IsNullOrWhiteSpace(paciente.Nome) || string.IsNullOrWhiteSpace(paciente.Email))
                    return BadRequest("Nome ou email não podem ser nulos.");

                using (SqlConnection conn = new SqlConnection()) // Cria uma conexão com o banco de dados
                {
                    conn.ConnectionString = Configurations.SQLServer.getConnectionString(); // Pega a string de conexão do arquivo de configurações
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
                return Ok(paciente);
            }
            catch (Exception ex)
            {
                using (StreamWriter sw = new StreamWriter(Configurations.Log.getLogPath(), true))
                {
                   System.Text.StringBuilder sb = new System.Text.StringBuilder();
                     sb.AppendLine("Data: " + DateTime.Now.ToString());
                        sb.AppendLine("Mensagem: " + ex.Message);
                        sb.AppendLine("StackTrace: " + ex.StackTrace);
                        sb.AppendLine("InnerException: " + ex.InnerException);
                        sb.AppendLine("Source: " + ex.Source);
                        sb.AppendLine("TargetSite: " + ex.TargetSite);
                        sb.AppendLine("--------------------------------------------------");
                        sw.WriteLine(sb.ToString());
                }
                return InternalServerError();
            }
        }

        // PUT: api/Pacientes/5
        public IHttpActionResult Put(int id, Models.Paciente paciente)
        {
            if (id != paciente.Codigo)
                return BadRequest("Código do paciente não confere.");
            if (string.IsNullOrWhiteSpace(paciente.Nome) || string.IsNullOrWhiteSpace(paciente.Email))
                return BadRequest("Nome e/ou Email não foram informados");

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Configurations.SQLServer.getConnectionString();
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "update paciente set nome = @nome, email = @email where codigo = @codigo;";
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = paciente.Codigo;
                    cmd.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = paciente.Nome;
                    cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar)).Value = paciente.Email;

                    cmd.ExecuteNonQuery();
                }
            }
            return Ok(paciente);
        }

        // DELETE: api/Pacientes/5
        public IHttpActionResult Delete(int id)
        {
            int linhaAfetadas = 0;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Configurations.SQLServer.getConnectionString();
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from paciente where codigo = @codigo;";
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = id;

                    linhaAfetadas = cmd.ExecuteNonQuery();
                }
            }
            if (linhaAfetadas == 0)
                return NotFound();

            return Ok();
        }
    }
}
