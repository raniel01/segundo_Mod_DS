using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemploAula7
{
    class Program
    {
        static void Main(string[] args)
        {
            // INTRODUÇÃO PARA CRIAÇÃO DO DIRETÓRIO TESTE
            Directory.CreateDirectory(@"c:\Teste\");

            //CRIA UM OBJETO PARA MANIPULAR A ESCRITA NO ARQUIVO
            StreamWriter wr = new StreamWriter(@"c:\Teste\Exemplo1.txt");
            wr.WriteLine("Primeira linha");
            wr.WriteLine("Segunda linha");
            wr.Close();

            //CRIA UM OBJETO PARA MANIPULAR UM ARQUIVO DE TEXTO
            StreamReader rd = new StreamReader(@"c:\Teste\Exemplo1.txt");
            while (!rd.EndOfStream)
            {
                string linha = rd.ReadLine();
                Console.WriteLine(linha);
            }
            rd.Close();

            Console.ReadKey();
        }
      
    }
}
