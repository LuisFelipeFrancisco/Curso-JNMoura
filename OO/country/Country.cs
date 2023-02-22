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
    internal class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public double Area { get; set; }

        public Country()
        {
            this.Name = "";
            this.Capital = "";
            this.Area = 0;
        }

        public Country(string name, string capital, double area)
        {
            Name = name;
            Capital = capital;
            Area = area;
        }

        public bool Equals(Country country)
        {
            return Name == country.Name && Capital == country.Capital;
        }
    }
}
