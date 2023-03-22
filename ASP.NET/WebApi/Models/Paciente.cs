namespace WebApi.Models
{
    public class Paciente
    {   
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Paciente()
        {
            this.Codigo = 0;
            this.Nome = "";
            this.Email = "";
        }
    }
}