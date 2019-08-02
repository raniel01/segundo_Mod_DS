using System;

namespace listaExercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 500;
            Veiculo[] v = new Veiculo[TAM]; // declaração do vetor veiculo
            int c=0; //variavel que servira como contador de veiculos cadastrados
            int op = 0;
            do
            {
                op = menu();
                switch (op)
                {
                    case 1: c++ cadastrarCarro(); break;
                    case 2: c++ cadastrarCaminhao(); break;
                    case 3: consultaPlaca(); break;
                    case 4: consultaCaminhaoMarca(); break;
                    case 5: consultarCaminhaoModelo(); break;
                    case 6: consultarCarroCor(); break;
                    case 7: exibirCarros(); break;
                    case 8: exibirCaminhao(); break;
                    case 0: break;
                    default: Console.WriteLine("Opção invalida"); break;
                }
                Console.SetCursorPosition(50, 20);
                Console.WriteLine("Tecle algo para continuar!");
                Console.ReadKey();
            } while (op != 0);
        }
        public static int menu()
        {
            Console.Clear();
            Console.WriteLine("*** Menu Principal - VEÍCULOS ***\n");
            Console.WriteLine("1 - Cadastrar carro");
            Console.WriteLine("2 - Cadastrar caminnão");
            Console.WriteLine("3 - Consulta por placa");
            Console.WriteLine("4 - Consulta de caminhão por * marca *");
            Console.WriteLine("5 - Consulta de caminhão por * modelo *");
            Console.WriteLine("6 - Consulta de carro por * cor *");
            Console.WriteLine("7 - Exibir carros");
            Console.WriteLine("8 - Exibir caminhões");
            Console.WriteLine("0 - Sair");
            Console.Write("\n Digite uma opção: ");
            return int.Parse(Console.ReadLine());
        }
        public static Carro cadastrarCarro()
        {
            // entrada de dados usando as variaveis auxiliares
            Console.Write("Digite o modelo: "); string mcar = Console.ReadLine();
            Console.Write("Digite o fabricante de ", mcar, " :"); string   fcar = Console.ReadLine();
            Console.Write("Digite a altura de {0}: ", n); double a = double.Parse(Console.ReadLine());
            Console.Write("Digite a letra correspondente ao sexo (M/F) ");
            char s = char.Parse(Console.ReadLine());

            // criando um objeto, usando o construtor com parametros
            return new Pessoa(n, i, a, s);
        }
    }
}
