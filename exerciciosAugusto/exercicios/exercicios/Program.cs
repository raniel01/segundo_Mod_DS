using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*1. Crie um vetor de 4 elementos (int), crie um método que alimente este vetor, crie um método que
            mostre os valores deste vetor e crie um método que multiplique por um número inteiro todos os
            valores do vetor.*/

            
             int[] x = new int[4];
            //metodos

            GerarVetor(x);
            ImprimirVetor(x);
            MultiplicarVetor(x);

            Console.ReadKey();
            
        }

        // metodo para multiplicar

        static void MultiplicarVetor(int[] x)
        {
            Console.WriteLine("Digite um numero multiplicador"); int mult = int.Parse(Console.ReadLine());

            Console.WriteLine("Posição 1 do vetor: " + (x[0] * mult));
            Console.WriteLine("Posição 2 do vetor: " + (x[1] * mult));
            Console.WriteLine("Posição 3 do vetor: " + (x[2] * mult));
            Console.WriteLine("Posição 4 do vetor: " + (x[3] * mult));

        }

        // metodo para imprimir
        
        static void ImprimirVetor (int[] x)
        {
            for ( int i = 0; i <  4; i++)
            {
                Console.WriteLine("Primeiro numero: " + x[i]);
            }
        }

        // metodo para gerar

        static void GerarVetor (int[] x)
        {
            for (int i = 0; i < 4; i++)
            {
                if (i != 0)
                {
                    Console.WriteLine("Digite mais um numero: "); int num = int.Parse(Console.ReadLine());
                    x[i] = num;

                }
                else
                {
                    Console.WriteLine("Digite um numero: "); int num = int.Parse(Console.ReadLine());
                    x[i] = num;
                }
                
            }

        }

    }
}
