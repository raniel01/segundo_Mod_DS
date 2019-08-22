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
        }
    }
}
