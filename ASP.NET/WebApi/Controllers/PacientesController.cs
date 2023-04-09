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
        public IHttpActionResult Get ()
        {
            try
            {
                return Ok(Repositories.Database.SQLServer.ADO.Paciente.Get(Configurations.SQLServer.getConnectionString()));
            }
            catch (Exception ex)
            {
                Logger.Log.write(ex, Configurations.Log.getLogPath());
                return InternalServerError();
            }
        }

        // GET: api/Pacientes/5
        public IHttpActionResult Get (int id) 
        {
            try
            {
                Models.Paciente paciente = Repositories.Database.SQLServer.ADO.Paciente.GetById(id, Configurations.SQLServer.getConnectionString());
                if (paciente.Codigo == 0)
                    return NotFound();

                return Ok(paciente);
            }
            catch (Exception ex)
            {
                Logger.Log.write(ex, Configurations.Log.getLogPath());
                return InternalServerError();
            }
        }

        // POST: api/Pacientes
        public IHttpActionResult Post (Models.Paciente paciente) // Recebe um paciente
        {
            try
            {
                if (string.IsNullOrWhiteSpace(paciente.Nome) || string.IsNullOrWhiteSpace(paciente.Email))
                    return BadRequest("Nome ou email não podem ser nulos.");

                Repositories.Database.SQLServer.ADO.Paciente.Add(paciente, Configurations.SQLServer.getConnectionString());
                return Ok(paciente);
            }
            catch (Exception ex)
            {
                Logger.Log.write(ex, Configurations.Log.getLogPath());
                return InternalServerError();
            }
        }

        // PUT: api/Pacientes/5
        public IHttpActionResult Put (int id, Models.Paciente paciente)
        {
            try
            {
                if (id != paciente.Codigo)
                    return BadRequest("Código do paciente não confere.");
                if (string.IsNullOrWhiteSpace(paciente.Nome) || string.IsNullOrWhiteSpace(paciente.Email))
                    return BadRequest("Nome e/ou Email não foram informados");

                int linhasAfetadas = Repositories.Database.SQLServer.ADO.Paciente.Update(id, paciente, Configurations.SQLServer.getConnectionString());

                if (linhasAfetadas == 0)
                    return NotFound();

                return Ok(paciente);
            }
            catch (Exception ex)
            {
                Logger.Log.write(ex, Configurations.Log.getLogPath());
                return InternalServerError();
            }
        }

        // DELETE: api/Pacientes/5
        public IHttpActionResult Delete (int id)
        {
            try
            {
                int linhasAfetadas = Repositories.Database.SQLServer.ADO.Paciente.Delete(id, Configurations.SQLServer.getConnectionString());

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
