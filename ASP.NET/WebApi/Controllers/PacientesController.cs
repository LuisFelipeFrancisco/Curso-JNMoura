using System.Collections.Generic;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class PacientesController : ApiController
    {
        // GET: api/Pacientes
        public List<Models.Paciente> Get()
        {
            Models.Paciente p1 = new Models.Paciente();
            p1.Nome = "Felipe";

            Models.Paciente p2 = new Models.Paciente();
            p2.Nome = "Luis";

            List<Models.Paciente> pacientes = new List<Models.Paciente>();
            pacientes.Add(p1);
            pacientes.Add(p2);

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
        public void Post([FromBody] string value)
        {
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
