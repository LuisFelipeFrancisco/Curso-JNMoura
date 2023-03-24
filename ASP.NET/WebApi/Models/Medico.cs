using System;

namespace WebApi.Models
{
    public class Medico
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }
        public DateTime? DataNascimento { get; set; }

        public Medico()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.Crm = "";
            this.DataNascimento = null;
        }
    }
}