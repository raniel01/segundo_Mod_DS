using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando a variavel stream 
            FileStream stream = new FileStream(@"Exemplo4.bin", FileMode.Open);

            // instanciado a variavel do tipo BinaryReader
            BinaryReader reader = new BinaryReader(stream);

            // variaveis recebendo os valores lidos pelo arquivo binário
            int idade = reader.ReadInt32();
            string nome = reader.ReadString();
            bool temFilhos = reader.ReadBoolean();
            double altura = reader.ReadDouble();

            // fecha o acesso com arquivo
            reader.Close();

            // exibe o resultado
            Console.WriteLine("Idade: {0}", Convert.ToString(idade));
            Console.WriteLine("Nome: {0}", nome);
            Console.WriteLine("Tem Filhos: {0}", Convert.ToString(temFilhos));
            Console.WriteLine("Altura: {0}", Convert.ToString(altura));
            Console.ReadKey();
        }
    }
}
