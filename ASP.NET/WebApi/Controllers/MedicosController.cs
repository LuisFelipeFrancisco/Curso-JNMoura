using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class MedicosController : ApiController
    {
        // GET: api/Medicos
        public List<Models.Medico> Get()
        {
            List<Models.Medico> medicos = new List<Models.Medico>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Configurations.SQLServer.getConnectionString();
                conn.Open();

                string commandText = "select codigo, nome, crm, datanascimento from medico;";

                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Models.Medico medico = new Models.Medico();
                            medico.Codigo = (int)dr["codigo"];
                            medico.Nome = dr["nome"].ToString();
                            medico.Crm = dr["crm"].ToString();
                            medico.DataNascimento = dr["datanascimento"] == DBNull.Value ? null : (DateTime?)dr["datanascimento"];

                            medicos.Add(medico);
                        }
                    }
                }
            }

            return medicos;
        }

        // GET: api/Medicos/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Medicos
        public void Post(Models.Medico medico)
        {
            using (SqlConnection conn= new SqlConnection())
            {
                conn.ConnectionString = Configurations.SQLServer.getConnectionString();
                conn.Open();

                string commandText = "insert into medico (nome, crm, datanascimento) values (@nome, @crm, @datanascimento);";

                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", medico.Nome); // AddWithValue é um método de SqlCommand que adiciona um parâmetro ao comando SQL e define seu valor, sem a necessidade de especificar o tipo do parâmetro.
                    cmd.Parameters.AddWithValue("@crm", medico.Crm);
                    cmd.Parameters.AddWithValue("@datanascimento", medico.DataNascimento);

                    cmd.ExecuteNonQuery();
                }

            }
        }

        // PUT: api/Medicos/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Medicos/5
        public void Delete(int id)
        {
        }
    }
}
