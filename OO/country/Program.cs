using System;
/*
 * Um país tem como atributos o seu nome, o nome da sua capital, sua dimensão em Km2. Implemente (codifique) uma classe
 * que represente um país conforme os itens abaixo:
 * 1 - Construtor vazio;
 * 2 - Construtor que inicialize o nome, capital e a dimensão do país;
 * 3 - Métodos get/set para seus atributos;
 * 4 - Um método que permita verificar se dois países são iguais. Dois países são iguais se eles tiverem o mesmo nome e a
 * mesma capital.
 *  a) A assinatura deste método deve ser:
 *          * public boolean igual(Pais pais).
*/

namespace country
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Country country1 = new Country();
            country1.Name = "Brazil";
            country1.Capital = "Brasilia";
            country1.Area = 8516000;
            Country country2 = new Country("Brazil", "Brasilia", 8515767);
            Country country3 = new Country("United States", "Washington", 9826675);

            Console.WriteLine($"Country 1: {country1.Name}, {country1.Capital}, {country1.Area}");
            Console.WriteLine($"Country 2: {country2.Name}, {country2.Capital}, {country2.Area}");

            Console.WriteLine($"Are {country1.Name} and {country2.Name} equals? {country1.Equals(country2)}");
            Console.WriteLine($"Are {country1.Name} and {country3.Name} equals? {country1.Equals(country3)}");
            Console.WriteLine($"Are {country2.Name} and {country3.Name} equals? {country2.Equals(country3)}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
