using System;
using System.IO;

namespace tryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numero1 = 0;

            do
            {
                try
                {
                    numero1 = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Por favor informe somente números.");
                    numero1 = -1;
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Por favor informe um número no intervalo de: {int.MinValue} a {int.MaxValue}.");
                    numero1 = -1;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Desculpe, ocorreu um erro que não esperávamos. Entre em contato com o suporte, ou tente novamente.");

                    using (StreamWriter sw = new StreamWriter("log.txt", true))
                    {
                        sw.WriteLine($"Data: {DateTime.Now}");
                        sw.WriteLine($"Mensagem: {ex.Message}");
                        sw.WriteLine($"StackTrace: {ex.StackTrace}");
                        sw.WriteLine($"InnerException: {ex.InnerException}");
                        sw.WriteLine($"Tipo de erro: {ex.GetType()}");
                        sw.WriteLine($"Source: {ex.Source}");
                        sw.WriteLine($"TargetSite: {ex.TargetSite}");
                        sw.WriteLine("-------------------------------------------------");
                    }

                    numero1 = -1;
                }

                finally
                {
                    Console.WriteLine("finally");
                }

            } while (numero1 < 0); // não podemos ter números negativos.

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}

/* 
* Criando um novo objeto do tipo StreamWriter
* Passando o nome do arquivo que será criado e o segundo parâmetro é para informar se o arquivo será sobrescrito ou não.
* O método WriteLine() escreve uma linha de texto no arquivo.
* O método Close() fecha o arquivo.
* O método Dispose() libera os recursos utilizados pelo objeto.
* Usando o bloco using, não precisamos nos preocupar com o fechamento do arquivo, pois o bloco using já faz isso por nós.
* Vantagens do bloco using: 
* 1 - Não precisamos nos preocupar com o fechamento do arquivo.
* 2 - Não precisamos nos preocupar com a liberação dos recursos utilizados pelo objeto.
* 3 - Não precisamos nos preocupar com a criação de variáveis para armazenar o objeto.
* Desvantagens do bloco using:
* 1 - Não podemos utilizar o objeto em outro escopo.
*/