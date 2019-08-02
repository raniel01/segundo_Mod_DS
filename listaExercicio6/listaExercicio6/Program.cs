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
                    case 3: 
                }
            }
        }
    }
}
