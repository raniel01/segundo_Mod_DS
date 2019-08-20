using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo3
{
    class Program
    {
        static void Main(string[] args)
        {

            String caminho = "c:\\Teste\\Exemplo2.txt";

            // Cria Objetos
            System.IO.StreamReader sr;
            string linhaAtual;

            // verificar se o arquivo não existe
            if (!System.IO.File.Exists(caminho))
            {
                throw (new System.IO.FileNotFoundException("Não foi possivel localizar o arquivo especificado"));
            }

            //Inicializa o StreamReader
            using (sr = new System.IO.StreamReader(caminho))
            {
                while (!sr.EndOfStream)
                {
                    // Recuperar limha
                    linhaAtual = sr.ReadLine();
                    Console.WriteLine(linhaAtual);
                }
            }
            Console.ReadKey();
        }
        
    }
}
