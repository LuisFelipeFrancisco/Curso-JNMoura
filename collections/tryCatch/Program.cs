using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

                    /*StreamWriter sw = new StreamWriter("log.txt", true);
                    sw.WriteLine($"\n------\nData:{DateTime.Now} \n Mensagem:{ex.Message} \n StackTrace:{ex.StackTrace} \n InnerException:{ex.InnerException} \n Tipo do erro: {ex.GetType()} \n Source: {ex.Source} \n TargetSite: {ex.TargetSite}");
                    sw.Close();
                    sw.Dispose();*/

                    using (StreamWriter sw = new StreamWriter("log.txt", true))
                    {
                        sw.WriteLine($"\n------\nData:{DateTime.Now} \n Mensagem:{ex.Message} \n StackTrace:{ex.StackTrace} \n InnerException:{ex.InnerException} \n Tipo do erro: {ex.GetType()} \n Source: {ex.Source} \n TargetSite: {ex.TargetSite}");
                    }

                    numero1 = -1;
                }
                /*finally
                {
                    Console.WriteLine("finally");
                }*/
            } while (numero1 < 0); // não podemos ter números negativos.


            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}