using System;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class MedicosController : ApiController
    {
        private readonly Repositories.IRepository<Models.Medico> repository;
        public MedicosController()
        {
            repository = new Repositories.Database.SQLServer.ADO.Medico(Configurations.SQLServer.getConnectionString());
        }

        // GET: api/Medicos
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

        // GET: api/Medicos/5
        public IHttpActionResult Get (int id)
        {
            try
            {
                Models.Medico medico = repository.GetById(id);
                if (medico == null)
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
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                repository.Add(medico);

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
                    ModelState.AddModelError("Codigo", "O código do médico não confere com o código informado na URL!");
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                int linhasAfetadas = repository.Update(id, medico);

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
