using System;

namespace atividade03
{
    internal class Program
    {
        interface IProgramador
        {
            void Programar();
        }

        interface IAnalista
        {
            void Analisar();
        }

        public class Aluno : IProgramador, IAnalista
        {

            public void Programar()
            {
                Console.WriteLine("Programando");
            }

            public void Analisar()
            {
                Console.WriteLine("Analisando");
            }

        }

        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.Programar();
            aluno.Analisar();

            Console.ReadKey();
        }
    }
}
