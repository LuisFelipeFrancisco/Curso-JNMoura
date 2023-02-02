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
 * @ Não aceitar valores negativos para o número de litros nem opções inválidas para o tipo de combustível
*/

namespace gasStation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double ALCOHOL_PRICE = 3.50;
            const double GASOLINE_PRICE = 5.00;
            const double DISCOUNT_ALCOHOL_20 = 0.02;
            const double DISCOUNT_ALCOHOL_20_PLUS = 0.05;
            const double DISCOUNT_GASOLINE_20 = 0.03;
            const double DISCOUNT_GASOLINE_20_PLUS = 0.06;
            int typeOfFuel;
            bool conversion = false; 
            double liters, priceOfFuel, discount, total;

            do {
                Console.WriteLine("Enter the type of fuel (1 - alcohol, 2 - gasoline):");
                conversion = int.TryParse(Console.ReadLine(), out typeOfFuel); // Tenta converter o valor digitado para inteiro caso seja possível a conversão, a variável conversion recebe true, caso contrário, recebe false 
            } while (!conversion || (typeOfFuel != 1 && typeOfFuel != 2)); // enquanto a conversão não for bem sucedida ou o tipo de combustível não for 1 ou 2

            do {
                Console.WriteLine("Enter the number of liters:");
                conversion = double.TryParse(Console.ReadLine(), out liters); // testa se a conversão foi bem sucedida
            } while (!conversion || liters < 0); // enquanto a conversão não for bem sucedida ou o número de litros for negativo

            priceOfFuel = typeOfFuel == 1 ? ALCOHOL_PRICE : GASOLINE_PRICE; // se o tipo de combustível for 1, o preço do combustível é o preço do álcool, caso contrário, é o preço da gasolina
            discount = liters <= 20 ? (typeOfFuel == 1 ? DISCOUNT_ALCOHOL_20 : DISCOUNT_GASOLINE_20) : (typeOfFuel == 1 ? DISCOUNT_ALCOHOL_20_PLUS : DISCOUNT_GASOLINE_20_PLUS); // se o número de litros for menor ou igual a 20, o desconto é o desconto de 2% ou 3% de acordo com o tipo de combustível, caso contrário, é o desconto de 5% ou 6% de acordo com o tipo de combustível
            total = liters * priceOfFuel * (1 - discount); // calcula o total a ser pago

            Console.WriteLine($"The total amount to be paid is {total:C}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}