using System;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class PacientesController : ApiController
    {
        private readonly Repositories.IRepository<Models.Paciente> repository;
        public PacientesController()
        {
            repository = new Repositories.Database.SQLServer.ADO.Paciente(Configurations.SQLServer.getConnectionString());
        }

        // GET: api/Pacientes
        public IHttpActionResult Get ()
        {
            try
            {
                return Ok(repository.Get());
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
                Models.Paciente paciente = repository.GetById(id);
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
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                repository.Add(paciente);

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
                    ModelState.AddModelError("Codigo", "O código do paciente não confere com o código informado na URL!");
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                int linhasAfetadas = repository.Update(id, paciente);

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
                int linhasAfetadas = repository.Delete(id);

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
