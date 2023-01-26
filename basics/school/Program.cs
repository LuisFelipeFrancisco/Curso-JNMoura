using System;
/* Faça um programa para ler três notas e o número de faltas de um aluno e escrever qual a sua situação final: 
* Aprovado, Reprovado por Falta ou Reprovado por Média. 
* A média para aprovação é 7,0 e o limite de faltas é 25% do total de aulas. 
* O número de aulas ministradas no semestre foi de 80. A reprovação por falta sobrepõe a reprovação por Média.
*/

namespace school
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your absences: ");
            int absences = int.Parse(Console.ReadLine());

            if (absences > 20)
            {
                Console.WriteLine("You are repproved by absences");
            }
            else
            {
                Console.WriteLine("Enter your first grade: ");
                double grade1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your second grade: ");
                double grade2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your third grade: ");
                double grade3 = double.Parse(Console.ReadLine());

                double average = (grade1 + grade2 + grade3) / 3;

                if (average >= 7)
                {
                    Console.WriteLine("You are approved");
                }
                else
                {
                    Console.WriteLine("You are repproved by average");
                }
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
