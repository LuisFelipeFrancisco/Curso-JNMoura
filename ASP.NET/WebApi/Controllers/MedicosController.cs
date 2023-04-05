﻿using System;
using System.Data.SqlClient;
using System.IO;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class MedicosController : ApiController
    {
        // GET: api/Medicos
        public IHttpActionResult Get()
        {
            return Ok(Repositories.Database.SQLServer.Medico.Get(Configurations.SQLServer.getConnectionString()));
        }

        // GET: api/Medicos/5
        public IHttpActionResult Get(int id)
        {
            Models.Medico medico = new Models.Medico();

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Configurations.SQLServer.getConnectionString();
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "select codigo, nome, crm, datanascimento from medico where codigo = @codigo;";
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = id;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            medico.Codigo = (int)dr["codigo"];
                            medico.Nome = dr["nome"].ToString();
                            medico.Crm = dr["crm"].ToString();
                            medico.DataNascimento = dr["datanascimento"] == DBNull.Value ? null : (DateTime?)dr["datanascimento"];
                        }
                    }
                }
            }

            if (medico.Codigo == 0)
                return NotFound();

            return Ok(medico);
        }

        // POST: api/Medicos
        public IHttpActionResult Post(Models.Medico medico)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(medico.Nome) || String.IsNullOrWhiteSpace(medico.Crm))
                    return BadRequest("Nome e CRM são obrigatórios.");
                
                using (SqlConnection conn= new SqlConnection())
                {
                    conn.ConnectionString = Configurations.SQLServer.getConnectionString();
                    conn.Open();

                    string commandText = "insert into medico (nome, crm, datanascimento) values (@nome, @crm, @datanascimento); select convert (int, @@identity) as Codigo;";

                    using (SqlCommand cmd = new SqlCommand(commandText, conn))
                    {
                        //cmd.Parameters.AddWithValue("@nome", medico.Nome); // AddWithValue é um método de SqlCommand que adiciona um parâmetro ao comando SQL e define seu valor, sem a necessidade de especificar o tipo do parâmetro.
                        cmd.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = medico.Nome; // Add é um método de SqlCommand que adiciona um parâmetro ao comando SQL.
                        cmd.Parameters.Add(new SqlParameter("@crm", System.Data.SqlDbType.VarChar)).Value = medico.Crm;
                        cmd.Parameters.Add(new SqlParameter("@datanascimento", System.Data.SqlDbType.DateTime)).Value = medico.DataNascimento;

                        //cmd.ExecuteNonQuery();
                        medico.Codigo = (int) cmd.ExecuteScalar(); // Executa o comando SQL e retorna o primeiro valor da primeira linha da primeira coluna do resultado. Se não houver resultado, retorna null.
                    }
                }
                return Ok(medico);
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

        // PUT: api/Medicos/5
        public IHttpActionResult Put(int id, Models.Medico medico)
        {
            if (id != medico.Codigo)
                return BadRequest("Código do médico inválido.");
            if (String.IsNullOrWhiteSpace(medico.Nome) || String.IsNullOrWhiteSpace(medico.Crm))
                return BadRequest("Nome e CRM são obrigatórios.");
            
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Configurations.SQLServer.getConnectionString();
                conn.Open();

                string commandText = "update medico set nome = @nome, crm = @crm, datanascimento = @datanascimento where codigo = @codigo;";

                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = medico.Codigo;
                    cmd.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = medico.Nome;
                    cmd.Parameters.Add(new SqlParameter("@crm", System.Data.SqlDbType.VarChar)).Value = medico.Crm;
                    cmd.Parameters.Add(new SqlParameter("@datanascimento", System.Data.SqlDbType.DateTime)).Value = medico.DataNascimento;

                    cmd.ExecuteNonQuery();
                }
            }
            return Ok(medico);
        }

        // DELETE: api/Medicos/5
        public IHttpActionResult Delete(int id)
        {
            int linhasAfetadas = 0;

            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Configurations.SQLServer.getConnectionString();
                conn.Open();

                string commandText = "delete from medico where codigo = @codigo;";

                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = id;

                    linhasAfetadas = cmd.ExecuteNonQuery();
                }
            }
            if (linhasAfetadas == 0)
                return NotFound();

            return Ok();
        }
    }
}