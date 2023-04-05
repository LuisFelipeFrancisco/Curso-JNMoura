using System;

namespace WebApi.Configurations
{
    public class Log
    {
        public static string getLogPath()
        {
            string fileName = $"{DateTime.Now.ToString("yyyy-MM-dd")}.txt";
            string path = System.Configuration.ConfigurationManager.AppSettings["caminho-arquivo-log"];
            string fullpath = System.IO.Path.Combine(path, fileName);
            return $@"C:\Users\luisf\Área de Trabalho\Curso-JNMoura\ASP.NET\WebApi\logs\{fileName}";
        }
    }
}