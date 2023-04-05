using System;

namespace Models
{
    public class Medico
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Crm { get; set; }
        public DateTime? DataNascimento { get; set; } // ? = Nullable (pode ser nulo)

        public Medico()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.Crm = "";
            this.DataNascimento = null;
        }
    }
}