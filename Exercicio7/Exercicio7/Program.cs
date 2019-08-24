using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            do
            {
                op = menu(); 
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Digite sua mensagem: ");
                        string msg =  Console.ReadLine();
                        //crindo diretário
                        //Directory.CreateDirectory(@"c:\Teste\");

                        //criando o arquivo
                        FileStream stream = new FileStream(@"C:\Users\Public\Exercicio2.bin", FileMode.Create);

                        // instanciando a variavel do tipo BinaryWrite
                        BinaryWriter writer = new BinaryWriter(stream);

                        //usando o metodo Write para escrever no arquivo
                        writer.Write(msg);

                        writer.Flush();
                        writer.Close();

                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("***** Mensagem ****** ");
                        string caminho = @"C:\Users\Public\Exercicio1.txt";
                        // criando objeto
                        System.IO.StreamReader sr;
                        String linhaAtual;

                        // verifica se o arquivo não existe
                        if (!System.IO.File.Exists(caminho))
                        {
                            throw (new System.IO.FileNotFoundException("Não Foi possível localizar o arquivo especificado"));
                        }

                        // iniciando o StreamReader

                        using (sr=new System.IO.StreamReader(caminho))
                        {
                            while (!sr.EndOfStream)
                            {
                                // recuperar linha
                                linhaAtual = sr.ReadLine();
                                Console.WriteLine(linhaAtual);
                            }
                        }
                        Console.ReadKey();
                    break;
                    case 0:  break;
                    default: Console.WriteLine("Opção Ivalida"); break;
                }
                Console.ReadKey();
            } while (op != 0);

        }
        public static int menu()
        {
            Console.Clear();
            Console.WriteLine("*****MENU PRINCIPAL*****\n");
            Console.WriteLine("1 - Escrever uma mensagem.");
            Console.WriteLine("2 - Leia uma mensagem.");
            Console.WriteLine("0 - SAIR");
            return int.Parse(Console.ReadLine());
        }
    }
}
