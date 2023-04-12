using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Paciente
    {   
        public int Codigo { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O nome é obrigatório!")]
        [StringLength(200, ErrorMessage = "O nome deve ter no máximo 200 caracteres!")]
        public string Nome { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "O email é obrigatório!")]
        [StringLength(100, ErrorMessage = "O email deve ter no máximo 100 caracteres!")]
        public string Email { get; set; }

        public Paciente()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.Email = "";
        }
    }
}