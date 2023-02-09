using System;
using System.Collections.Generic;


/*
 * Durante uma corrida de automóveis com N voltas de duração foram anotados para um piloto, na ordem, os tempos
 * registrados em cada volta. Fazer um programa para ler os tempos das N voltas, calcular e imprimir:
 * a) melhor tempo
 * b) volta em que o melhor tempo ocorreu;
 * c) tempo médio das N voltas; 
 * Importante: Para encerrar o programa o usuário indica que não deseja mais informar o tempo da volta.
*/

namespace race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> tempos = new List<double>();
            double melhorTempo = 0;
            int voltaMelhorTempo = 0;
            double tempoMedio = 0;

            Console.WriteLine("Digite o tempo da volta ou 0 para sair: ");
            while (true)
            {
                Console.Write($"{tempos.Count + 1}º tempo: ");
                if (double.TryParse(Console.ReadLine(), out double tempo))
                {
                    if (tempo == 0)
                    {
                        break;
                    }
                    else 
                    {
                        tempos.Add(tempo);
                        tempoMedio += tempo;
                        if (melhorTempo == 0 || tempo < melhorTempo)
                        {
                            melhorTempo = tempo;
                            voltaMelhorTempo = tempos.Count;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Tempo inválido. Digite novamente: ");
                }
            }

            Console.WriteLine($"Melhor tempo: {melhorTempo}");
            Console.WriteLine($"Volta em que o melhor tempo ocorreu: {voltaMelhorTempo}");
            Console.WriteLine($"Tempo médio das {tempos.Count} voltas: {tempoMedio / tempos.Count}");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
