using System;

/*
 * 1 - implementar o diagrama de classes passado em sala de aula em C#
 * Classes: Conta, ContaCorrente, ContaPoupanca, SeguroDeVida;
 * Interface: Tributavel;
 * Aonde ContaCorrete e ContaPoupanca irão herdar de Conta;
 * E ContaCorrente e SeguroDeVida irão implementar Tritutavel.
 * 
 * i. ContaPoupanca cp = new ContaPoupanca();
 * ii. ContaCorrente cc = new ContaCorrente();
 * iii. Tributavel t1 = cp;
 * iv. Tributavel t2 = cc;
 * 
 * O código da linha iii poderá ser executado sem erros? Explique o motivo.
 */

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaPoupanca cp = new ContaPoupanca(10);
            ContaCorrente cc = new ContaCorrente(11);

            //ITributavel t1 = cp; Teremos um erro de compilação, pois a classe ContaPoupanca não implementa a interface Tributavel.

            ITributavel t2 = cc; // Não teremos erro de compilação, pois a classe ContaCorrente implementa a interface Tributavel. 

            t2.Tributo = 10;

            Console.WriteLine($"Tributo: {t2.Tributo}");

            Console.ReadKey();

        }
    }
}
