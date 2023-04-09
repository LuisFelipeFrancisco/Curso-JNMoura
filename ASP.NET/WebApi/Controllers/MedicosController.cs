using System;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class MedicosController : ApiController
    {
        // GET: api/Medicos
        public IHttpActionResult Get ()
        {
            try
            {
                return Ok(Repositories.Database.SQLServer.ADO.Medico.Get(Configurations.SQLServer.getConnectionString()));
            }
            catch (Exception ex) 
            {
                Logger.Log.write(ex, Configurations.Log.getLogPath());
                return InternalServerError();
            }
        }

        // GET: api/Medicos/5
        public IHttpActionResult Get (int id)
        {
            try
            {
                Models.Medico medico = Repositories.Database.SQLServer.ADO.Medico.GetById(id,Configurations.SQLServer.getConnectionString());
                if (medico.Codigo == 0)
                    return NotFound();

                return Ok(medico);
            }
            catch (Exception ex)
            {
                Logger.Log.write(ex, Configurations.Log.getLogPath());
                return InternalServerError();
            }
        }

        // POST: api/Medicos
        public IHttpActionResult Post (Models.Medico medico)
        {
            try
            {
                if (String.IsNullOrWhiteSpace(medico.Nome) || String.IsNullOrWhiteSpace(medico.Crm))
                    return BadRequest("Nome e CRM são obrigatórios.");

                if (medico.Nome.Length > 200 || medico.Crm.Length > 9)
                    return BadRequest("Nome não pode ser maior que 200, Crm não pode ser maior que 9");

                Repositories.Database.SQLServer.ADO.Medico.Add(medico, Configurations.SQLServer.getConnectionString());

                return Ok(medico);
            }
            catch (Exception ex)
            {
                Logger.Log.write (ex, Configurations.Log.getLogPath());
                return InternalServerError(); 
            }   
        }   

        // PUT: api/Medicos/5
        public IHttpActionResult Put (int id, Models.Medico medico)
        {
            try
            {
                if (id != medico.Codigo)
                    return BadRequest("Código do médico inválido.");
                if (String.IsNullOrWhiteSpace(medico.Nome) || String.IsNullOrWhiteSpace(medico.Crm))
                    return BadRequest("Nome e CRM são obrigatórios.");

                int linhasAfetadas = Repositories.Database.SQLServer.ADO.Medico.Update(id, medico, Configurations.SQLServer.getConnectionString());

                if (linhasAfetadas == 0)
                    return NotFound();

                return Ok(medico);
            }
            catch (Exception ex)
            {
                Logger.Log.write(ex, Configurations.Log.getLogPath());
                return InternalServerError();
            }
        }

        // DELETE: api/Medicos/5
        public IHttpActionResult Delete (int id)
        {
            try
            {
                int linhasAfetadas = Repositories.Database.SQLServer.ADO.Medico.Delete(id, Configurations.SQLServer.getConnectionString());

                if (linhasAfetadas == 0)
                    return NotFound();

                return Ok();
            }
            catch (Exception ex)
            {
                Logger.Log.write(ex, Configurations.Log.getLogPath());
                return InternalServerError();
            }
        }
    }
}
