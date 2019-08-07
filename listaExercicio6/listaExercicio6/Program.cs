using System;

namespace listaExercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int TAMCAR = 300;
            Carro[] carro = new Carro[TAMCAR]; // declaração do vetor veiculo
            int ccar = 0; //variavel que servira como contador de carro cadastrados

            const int TAMCAM = 200;
            Caminhao[] caminhao = new Caminhao[TAMCAM]; // declaração do vetor veiculo
            int ccam = 0; //variavel que servira como contador de carro cadastrados

            int op = 0;
            do
            {
                op = menu();
                switch (op)
                {
                    case 1: carro[ccar++] = cadastrarCarro(); break;
                    case 2: caminhao[ccam++] = cadastrarCaminhao(); break;
                    case 3: consultaPlaca(carro, caminhao); break;
                    case 4: consultarCaminhaoModelo(caminhao); break;
                    case 5: consultarCarroCor(carro); break;
                    case 6: exibirCarros(carro); break;
                    case 7: exibirCaminhao(caminhao); break;
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
            Console.WriteLine("4 - Consulta de caminhão por * modelo *");
            Console.WriteLine("5 - Consulta de carro por * cor *");
            Console.WriteLine("6 - Exibir carros");
            Console.WriteLine("7 - Exibir caminhões");
            Console.WriteLine("0 - Sair");
            Console.Write("\n Digite uma opção: ");
            return int.Parse(Console.ReadLine());
        }
        public static Carro cadastrarCarro()
        {
            Console.Clear();
            Console.WriteLine("*** CADASTRO DE CARRO ***\n");
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
            Console.Clear();
            Console.WriteLine("*** CADASTRO DE CAMINHÃO ***\n");
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
        public static void consultaPlaca(Carro[] conCarro, Caminhao[] conCaminhao)
        {
            Console.Clear();
            Console.WriteLine("*** CONSULTA POR PLACA ***\n");
            Console.Write("Digite a placa do veículo que deseja consultar: "); string consPlaca = Console.ReadLine();

            for (int contCar = 0; contCar < conCarro.Length; contCar++)
            {
                if (conCarro[contCar] != null && conCarro[contCar].Placa == consPlaca)
                {
                    Console.WriteLine();
                    Console.WriteLine(conCarro[contCar].ToString());
                   
                }
              
            }

            for (int contCam = 0; contCam < conCaminhao.Length; contCam++)
            {
                if (conCaminhao[contCam] != null && conCaminhao[contCam].Placa == consPlaca)
                {
                    Console.WriteLine();
                    Console.WriteLine(conCaminhao[contCam].ToString());
                   
                }
                
            }
        }
        public static void consultarCaminhaoModelo(Caminhao[] conCaminhao)
        {
            Console.Clear();
            Console.WriteLine("*** CONSULTA DE CAMINÃO POR MODELO ***\n");

            Console.Write("Digite a marca do caminhão que deseja consultar: "); string consModelo = Console.ReadLine();

            for (int contCam = 0; contCam < conCaminhao.Length; contCam++)
            {
                if (conCaminhao[contCam] != null && conCaminhao[contCam].Modelo == consModelo)
                {
                    Console.WriteLine();
                    Console.WriteLine(conCaminhao[contCam].ToString());

                }
            }   
        }
        public static void consultarCarroCor(Carro[] conCarro)
        {
            Console.Clear();
            Console.WriteLine("*** CONSULTA DE CARRO POR COR ***\n");

            Console.Write("Digite a cor do carro que deseja consultar: "); string consCarro = Console.ReadLine();

            for (int contCar = 0; contCar < conCarro.Length; contCar++)
            {
                if (conCarro[contCar] != null && conCarro[contCar].Cor== consCarro)
                {
                    Console.WriteLine();
                    Console.WriteLine(conCarro[contCar].ToString());

                }
            }
        }
        public static void exibirCaminhao(Caminhao[] conCaminhao)
        {
            Console.Clear();
            Console.WriteLine("*** EXIBIR CARROS ***\n");

            for (int contCam = 0; contCam < conCaminhao.Length; contCam++)
            {
                if (conCaminhao[contCam] != null)
                {
                    Console.WriteLine();
                    Console.WriteLine(conCaminhao[contCam].ToString());
                    Console.WriteLine("**********************************");
                }
                    

            }
        }
        public static void exibirCarros(Carro[] conCarro)
        {
            Console.Clear();
            Console.WriteLine("*** EXIBIR CARROS ***\n");

            for (int contCar = 0; contCar < conCarro.Length; contCar++)
            {
                if (conCarro[contCar] != null)
                {
                    Console.WriteLine();
                    Console.WriteLine(conCarro[contCar].ToString());
                    Console.WriteLine("**********************************");
                }


            }
        }
    }
       
}
