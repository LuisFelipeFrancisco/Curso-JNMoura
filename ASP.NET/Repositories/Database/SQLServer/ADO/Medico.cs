using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repositories.Database.SQLServer.ADO
{
    public class Medico: IRepository<Models.Medico>
    {
        private readonly SqlConnection conn; // readonly: o valor de uma variável readonly pode ser atribuído apenas no momento da declaração ou no construtor da classe.
        private readonly string chaveCache;
        public Medico (String connectionString)
        {
            conn = new SqlConnection (connectionString);
            chaveCache = "medicos";
        }

        public List<Models.Medico> Get ()
        {
            List<Models.Medico> medicos = (List<Models.Medico>)Cache.Get(chaveCache);
            if (medicos != null)
                return medicos;

            medicos = new List<Models.Medico>();

            using (conn)
            {
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
            Cache.Set(chaveCache, medicos, 1);

            return medicos;
        }
        
        public Models.Medico GetById (int id)
        {
            List<Models.Medico> medicos = (List<Models.Medico>)Cache.Get(chaveCache);

            if (medicos != null)
                return medicos.Find(medicoCache => medicoCache.Codigo == id);

            Models.Medico medico = new Models.Medico();

            using (conn)
            {
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
            return medico;
        }

        public void Add (Models.Medico medico)
        {
            using (conn)
            {
                conn.Open();

                string commandText = "insert into medico (nome, crm, datanascimento) values (@nome, @crm, @datanascimento); select convert (int, @@identity) as Codigo;";

                using (SqlCommand cmd = new SqlCommand(commandText, conn))
                {
                    //cmd.Parameters.AddWithValue("@nome", medico.Nome); // AddWithValue é um método de SqlCommand que adiciona um parâmetro ao comando SQL e define seu valor, sem a necessidade de especificar o tipo do parâmetro.
                    cmd.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = medico.Nome; // Add é um método de SqlCommand que adiciona um parâmetro ao comando SQL.
                    cmd.Parameters.Add(new SqlParameter("@crm", System.Data.SqlDbType.VarChar)).Value = medico.Crm;
                    if (medico.DataNascimento != null)
                        cmd.Parameters.Add(new SqlParameter("@datanascimento", System.Data.SqlDbType.Date)).Value = medico.DataNascimento;
                    else
                        cmd.Parameters.Add(new SqlParameter("@datanascimento", System.Data.SqlDbType.Date)).Value = DBNull.Value;

                    //cmd.ExecuteNonQuery();
                    medico.Codigo = (int)cmd.ExecuteScalar(); // Executa o comando SQL e retorna o primeiro valor da primeira linha da primeira coluna do resultado. Se não houver resultado, retorna null.
                }
            }
            Cache.Remove(chaveCache);
        }

        public int Update (int id, Models.Medico medico)
        {
            int linhasAfetadas = 0;

            using (conn)
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "update medico set nome = @nome, crm = @crm, datanascimento = @datanascimento where codigo = @codigo;";

                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = medico.Codigo;
                    cmd.Parameters.Add(new SqlParameter("@nome", System.Data.SqlDbType.VarChar)).Value = medico.Nome;
                    cmd.Parameters.Add(new SqlParameter("@crm", System.Data.SqlDbType.VarChar)).Value = medico.Crm;
                    //cmd.Parameters.Add(new SqlParameter("@datanascimento", System.Data.SqlDbType.DateTime)).Value = medico.DataNascimento;
                    if (medico.DataNascimento != null)
                        cmd.Parameters.Add(new SqlParameter("@datanascimento", System.Data.SqlDbType.Date)).Value = medico.DataNascimento;
                    else
                        cmd.Parameters.Add(new SqlParameter("@datanascimento", System.Data.SqlDbType.Date)).Value = DBNull.Value;

                    linhasAfetadas = cmd.ExecuteNonQuery();
                }
            }
            Cache.Remove(chaveCache);

            return linhasAfetadas;
        }

        public int Delete (int id)
        {
            int linhasAfetadas = 0;

            using (conn)
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = "delete from medico where codigo = @codigo;";

                    cmd.Parameters.Add(new SqlParameter("@codigo", System.Data.SqlDbType.Int)).Value = id;

                    linhasAfetadas = cmd.ExecuteNonQuery();
                }
            }
            Cache.Remove(chaveCache);

            return linhasAfetadas;
        }
    }
}
