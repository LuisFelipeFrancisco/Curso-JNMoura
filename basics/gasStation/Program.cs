using System;
/* 
 * Analise a seguinte informação:
 * Em um jogo, existe um posto que está vendendo combustíveis com a seguinte tabela de descontos:
 * 
 * Álcool
 * até 20 litros (inclusive 20 litros), desconto de 2% por litro
 * acima de 20 litros, desconto de 5% por litro
 * 
 * Gasolina
 * até 20 litros (inclusive 20 litros), desconto de 3% por litro
 * acima de 20 litros, desconto de 6% por litro
 * 
 * Após à análise, faça um programa que leia o número de litros vendidos e o tipo de combustível (codificado da
 * seguinte forma: 1-álcool, 2-gasolina), calcule e imprima o valor
 * a ser pago pelo jogador, sabendo-se que o preço do litro da gasolina é R$ 5.00 e o preço do litro do álcool é R$
 * 3.50
*/

namespace gasStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double liters, price, discount, total;
            Console.WriteLine("Enter the number of liters: ");
            liters = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the type of fuel (1 - Alcohol, 2 - Gasoline): ");
            int type = int.Parse(Console.ReadLine());
            if (type == 1)
            {
                price = 3.50;
                if (liters <= 20)
                {
                    discount = 0.02;
                }
                else
                {
                    discount = 0.05;
                }
            }
            else
            {
                price = 5.00;
                if (liters <= 20)
                {
                    discount = 0.03;
                }
                else
                {
                    discount = 0.06;
                }
            }
            total = liters * price * (1 - discount);
            Console.WriteLine($"The total to pay is: {total:C}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
