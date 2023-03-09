using System;
/* O jogador escolhe par ou ímpar e informa um número. 
* Depois, o computador escolhe um número aleatório.
* Agora, você deve:
* • Continuar o código do jogo para decidir quem ganha: jogador ou computador.
* • Deixar o jogador jogar quantas vezes desejar, até ele indicar que deseja parar.
* • Depois da parada, apresentar o placar final do jogo informando quem ganhou. Exemplo: Jogador: 10 x
* Computador:5 (Jogador ganhou).
* Mas não se esqueça, pode dar empate.
*/

namespace ParOuImpar
{
    class Program
    {        
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("------Bem vindo ao jogo do Par ou Ímpar------");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("");

            bool continuarJogando = true;
            int placarJogador = 0;
            int placarComputador = 0;

            do
            {
                Console.Write("Você quer par (p) ou ímpar (i)? ");
                string opcaoJogador = Console.ReadLine();

                Console.Write("Informe um número inteiro: ");
                int numeroJogador = int.Parse(Console.ReadLine());

                Random roleta = new Random(); // Random -> Tipo que nos permite selecionar um número randômico (aleatório).
                int numeroComputador = roleta.Next(100); // seleciona um numero entre 0 e 99.

                int soma = numeroJogador + numeroComputador;

                Console.WriteLine($"O computador escolheu o número {numeroComputador}.");
                Console.WriteLine($"A soma dos números é {soma}.");

                if (soma % 2 == 0)
                {
                    Console.WriteLine("O número é par.");
                    if (opcaoJogador == "p")
                    {
                        Console.WriteLine("Você ganhou a rodada");
                        placarJogador++;
                    }
                    else
                    {
                        Console.WriteLine("Você perdeu a rodada!");
                        placarComputador++;
                    }
                }
                else
                {
                    Console.WriteLine("O número é ímpar.");
                    if (opcaoJogador == "i")
                    {
                        Console.WriteLine("Você ganhou a rodada!");
                        placarJogador++;
                    }
                    else
                    {
                        Console.WriteLine("Você perdeu a rodada!");
                        placarComputador++;
                    }
                }

                Console.Write("Deseja continuar jogando (s/n)? ");
                continuarJogando = Console.ReadLine() == "s";

            } while (continuarJogando);

            Console.WriteLine($"Placar final: Jogador {placarJogador} x Computador {placarComputador}.");

            Console.WriteLine(placarJogador > placarComputador ? "Você ganhou o jogo!" : placarJogador < placarComputador ? "Você perdeu o jogo!" : "O jogo terminou empatado!");

            Console.WriteLine("Obrigado por jogar!");

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
            
        }
    }
}