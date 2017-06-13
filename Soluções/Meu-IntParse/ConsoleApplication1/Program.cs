using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
        class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine(2 * MeuIntParse(Console.ReadLine()));
            }

            public static int MeuIntParse(string nroComoStr)
            {
                int multiplicar = 1;
                int total = 0;
                int i;

                for (i = nroComoStr.Length - 1; i >= 0; i--) 
                    {
                        total += (nroComoStr[i] - '0') * multiplicar;
                        multiplicar *= 10;
                    }
 
                return total;
        }
    }
}
