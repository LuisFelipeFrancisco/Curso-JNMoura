using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Medico
    {
        public int Codigo { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O nome é obrigatório!")]
        [StringLength(200, ErrorMessage = "O nome deve ter no máximo 200 caracteres!")]
        public string Nome { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O CRM é obrigatório!")]
        [StringLength(9, ErrorMessage = "O CRM deve ter no máximo 09 caracteres!")]
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