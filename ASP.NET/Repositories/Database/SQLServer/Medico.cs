using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Repositories.Database.SQLServer
{
    public class Medico
    {
        public static List<Models.Medico> Get(string connectionString)
        {

            List<Models.Medico> medicos = new List<Models.Medico>();
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = connectionString;
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
    }
}
