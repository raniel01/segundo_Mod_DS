using System;

namespace listaExercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAM = 500;
            Veiculo[] v = new Veiculo[TAM]; // declaração do vetor veiculo
            int c = 0; //variavel que servira como contador de veiculos cadastrados
            int op = 0;
            do
            {
                op = menu();
                switch (op)
                {
                    case 1: v[c++] = cadastrarCarro(); break;
                    case 2: v[c++] = cadastrarCaminhao(); break;
                   // case 3: consultaPlaca(); break;
                   // case 4: consultaCaminhaoMarca(); break;
                   // case 5: consultarCaminhaoModelo(); break;
                   // case 6: consultarCarroCor(); break;
                   // case 7: exibirCarros(); break;
                    //case 8: exibirCaminhao(); break;
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
            Console.Write("Digite o fabricante: "); string   fcar = Console.ReadLine();
            Console.Write("Digite o ano de fabricação: "); int   ano = int.Parse( Console.ReadLine());
            Console.Write("Digite a cor: "); string cor = Console.ReadLine();
            Console.Write("Digite o numero de portas: "); int portas = int.Parse(Console.ReadLine());
            Console.Write("Digite a placa: "); string placa = Console.ReadLine();
            Console.Write("Digite a capacidade do porta malas: "); int portaMalas = int.Parse(Console.ReadLine()); 
            Console.Write("O veiculo tem bagageiro <S/N> ?");  string r = Console.ReadLine(); bool bagageiro = r.ToUpper() == "S" ? true : false;
            Console.Write("Digite o tipo de carro: "); string carroceria = Console.ReadLine();


            // criando um objeto, usando o construtor com parametros
            return new Carro(mcar, fcar, ano, cor, portas, placa, portaMalas, bagageiro, carroceria);
        }
        public static Caminhao cadastrarCaminhao()
        {
            // entrada de dados usando as variaveis auxiliares
            Console.Write("Digite o modelo: "); string mcam = Console.ReadLine();
            Console.Write("Digite o fabricante: "); string fcam = Console.ReadLine();
            Console.Write("Digite o ano de fabricação: "); int ano = int.Parse(Console.ReadLine());
            Console.Write("Digite a cor: "); string cor = Console.ReadLine();
            Console.Write("Digite o numero de portas: "); int portas = int.Parse(Console.ReadLine());
            Console.Write("Digite a placa: "); string placa = Console.ReadLine();
            Console.Write("Quantos eixos? "); int eixo = int.Parse(Console.ReadLine());
            Console.Write("Qual peso maximo da carga? "); double peso = double.Parse(Console.ReadLine());
            Console.Write("Qual tipo do caminhão? "); string tipo = Console.ReadLine();


            // criando um objeto, usando o construtor com parametros
            return new Caminhao (mcam, fcam, ano, cor, portas, placa, eixo, peso, tipo);
        }
        public static void consultaPlaca (Veiculo[] v, string placa)
        {

        }

    }
}
