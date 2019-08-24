using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando as variáveis
            int idade = 25;
            string nome = "Sergio";
            bool temFilhos = false;
            double altura = 1.79;

            //criando o arquivo
            FileStream stream = new FileStream(@"Exemplo4.bin", FileMode.Create);

            // iniciando a variável do tipo BinaryWriter
            BinaryWriter writer = new BinaryWriter(stream);

            // usando o método Write para escrever no arquivo
            writer.Write(idade);
            writer.Write(nome);
            writer.Write(temFilhos);
            writer.Write(altura);

            writer.Flush();
            writer.Close();
        }
    }
}
