using System.Collections.Generic;
using System.Data.SqlClient;
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
        public Models.Paciente Get(int id) 
        {
            Models.Paciente p1 = new Models.Paciente(); 
            p1.Nome = "Luis Felipe";

            return p1;
        }

        // POST: api/Pacientes
        public void Post(Models.Paciente paciente) // Recebe um paciente
        {
            using (SqlConnection conn = new SqlConnection()) // Cria uma conexão com o banco de dados
            {
                conn.ConnectionString = Configurations.SQLServer.getConnectionString(); // Pega a string de conexão do arquivo de configurações
                conn.Open(); // Abre a conexão com o banco de dados

                using (SqlCommand cmd = new SqlCommand()) // Cria um comando SQL
                {
                    cmd.Connection = conn; // Informa a conexão que o comando SQL deve usar
                    cmd.CommandText = "insert into paciente (codigo, nome, email) values (@codigo, @nome, @email)"; // Informa o comando SQL que deve ser executado, com parâmetros
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = paciente.Codigo; 
                    cmd.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar, 200)).Value = paciente.Nome;
                    cmd.Parameters.Add(new SqlParameter("@email", System.Data.SqlDbType.VarChar, 100)).Value = paciente.Email;
                    cmd.ExecuteNonQuery(); // Executa o comando SQL, non query pois não retorna dados
                }
            }
        }

        // PUT: api/Pacientes/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Pacientes/5
        public void Delete(int id)
        {
        }
    }
}
