using System;

namespace Aula6_Exemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            // entrada de dados usando as variaveis auxiliares
            Console.Write("Digite o nome da pessoa: "); string n = Console.ReadLine();
            Console.Write("Digite a idade de {0}: ", n); int i = int.Parse(Console.ReadLine());
            Console.Write("Digite a altura de {0}: ", n); double a = double.Parse(Console.ReadLine());
            Console.Write("Digite a letra correspondente ao sexo (M/F) ");
            char s = char.Parse(Console.ReadLine());

            // criando um objeto, usando o construtor com parametros
            Pessoa pessoa = new Pessoa(n, i, a, s);

            // exibindo os dados da pessoa cadastrada
            Console.WriteLine("\n\n*** DADOS DA PESSOA ***/n");
            Console.WriteLine(pessoa.ToString());

            // exibinso o resultado do calculo do peso ideal
            Console.WriteLine(" Peso iedeal: {0}", pessoa.calcularPesoIdeal());

            Console.ReadKey();

        }
    }
}
