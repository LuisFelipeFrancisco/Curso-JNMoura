using System;
using System.Collections.Generic;
/*Faça um programa para gerenciar senhas numéricas referentes à fila de atendimento de um banco, compreendendo
 * senhas para atendimento comum e prioritário. As senhas são números sequenciais inteiros maiores que 0 (zero) e
 * não podem ser repetidas durante a execução do programa.
 * Todas as senhas devem ser ordenadas por ordem de chegada, mas as senhas de atendimento prioritário devem ser
 * chamadas antes das senhas comuns, ou seja, as senhas comuns só podem ser chamadas quando não existirem
 * senhas de atendimento prioritário.
 * Assim, o programa deve ter quatro opções de entrada para o usuário:
 * 1. Gerar senha para atendimento comum;
 * 2. Gerar senha para atendimento prioritário;
 * 3. Chamada da senha para atendimento;
 * 4. Encerramento do atendimento;
 * 5. Visualizar fila de chamada;(lembrando que as senhas de atendimento prioritário possuem preferência em relação
 * às senhas para atendimento comum.)
 * Ressalta-se que a opção 3, chamada da senha, deve exibir a senha do atendimento ou avisar o usuário que não
 * existem mais senhas na fila de atendimento e, a opção 4, de encerramento do atendimento, só poderá ser executada
 * quando não existirem mais senhas para atendimento, imprimindo na tela do usuário "Atendimento Encerrado".
 */

namespace Senhas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("------Bem vindo ao programa de controle de senhas ------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("");

            int opcao = 0;
            int ultimaSenhaGerada = 0;
            bool encerrarAtendimento = false;

            Queue<int> filaComum = new Queue<int>();
            Queue<int> filaPrioritaria = new Queue<int>();

            do {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Gerar senha para atendimento comum");
                Console.WriteLine("2 - Gerar senha para atendimento prioritário");
                Console.WriteLine("3 - Chamada da senha para atendimento");
                Console.WriteLine("4 - Encerramento do atendimento");
                Console.WriteLine("5 - Visualizar fila de chamada");
                Console.WriteLine("");

                opcao = int.TryParse(Console.ReadLine(), out opcao) ? opcao : 0;

                switch (opcao)
                {
                    case 1:
                        ultimaSenhaGerada++;
                        filaComum.Enqueue(ultimaSenhaGerada);
                        Console.WriteLine("Senha gerada com sucesso!");
                        Console.WriteLine($"Senha gerada: {ultimaSenhaGerada}");
                        Console.WriteLine("");
                        break;
                    case 2:
                        ultimaSenhaGerada++;
                        filaPrioritaria.Enqueue(ultimaSenhaGerada);
                        Console.WriteLine("Senha gerada com sucesso!");
                        Console.WriteLine($"Senha gerada: {ultimaSenhaGerada}");
                        Console.WriteLine("");
                        break;
                    case 3:
                        if (filaPrioritaria.Count > 0)
                        {
                            Console.WriteLine($"Senha para atendimento prioritário: {filaPrioritaria.Dequeue()}");
                            Console.WriteLine("");
                        }
                        else if (filaComum.Count > 0)
                        {
                            Console.WriteLine($"Senha para atendimento comum: {filaComum.Dequeue()}");
                            Console.WriteLine("");
                        }
                        else
                        {
                            Console.WriteLine("Não existem mais senhas para atendimento");
                            Console.WriteLine("");
                        }
                        break;
                    case 4:
                        if (filaPrioritaria.Count == 0 && filaComum.Count == 0)
                        {
                            encerrarAtendimento = true;
                        }
                        else
                        {
                            Console.WriteLine("Não é possível encerrar o atendimento, pois ainda existem senhas para atendimento");
                            Console.WriteLine("");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Senhas restantes em ordem de atendimento:");
                        Console.WriteLine("");

                        foreach (int senha in filaPrioritaria)
                        {
                            Console.WriteLine($"Senha prioritária: {senha}");
                        }

                        foreach (int senha in filaComum)
                        {
                            Console.WriteLine($"Senha comum: {senha}");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        Console.WriteLine("");
                        break;
                }
            } while (!encerrarAtendimento);
            
            Console.WriteLine("Atendimento Encerrado");
            
            Console.WriteLine("Pressione qualquer tecla para sair");
            Console.ReadLine();
        }
    }
}   