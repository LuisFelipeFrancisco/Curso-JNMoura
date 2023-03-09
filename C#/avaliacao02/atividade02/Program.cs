using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade02
{
    internal class Program
    {
        public abstract class Pessoa
        {    
            protected string primeiroNome;
            protected string ultimoNome;

            public Pessoa(string primeiroNome, string ultimoNome)
            {
                this.primeiroNome = primeiroNome;
                this.ultimoNome = ultimoNome;
            }

            public virtual double valorCopiasXerox(int quantidade)
            {
                return quantidade * 2;
            }
        }

        public sealed class Aluno : Pessoa
        {
            private string registro;

            public Aluno(string primeiroNome, string ultimoNome, string registro)
                : base(primeiroNome, ultimoNome)
            {
                this.registro = registro;
            }

            public override double valorCopiasXerox(int quantidade)
            {
                return quantidade * 1;
            }
        }

        public class Funcionario : Pessoa
        {
            private double salario;

            public Funcionario(string primeiroNome, string ultimoNome, double salario)
                : base(primeiroNome, ultimoNome)
            {
                this.salario = salario;
            }

            public double getSalario()
            {
                return this.salario;
            }

            public double setSalario(double salario)
            {
                return this.salario = salario;
            }
        }

        static void Main(string[] args)
        {

            //Pessoa maria = new Pessoa ("Maria", "Joaquina");

            Funcionario joao = new Funcionario("João", "Silva", 1500);
            Console.WriteLine("Valor da cópia: " + joao.valorCopiasXerox(10));

            Aluno zeca = new Aluno("Zeca", "Beats", "RA3210");
            Console.WriteLine("Valor da cópia: " + zeca.valorCopiasXerox(10));

            Console.ReadKey();
        }
    }
}
