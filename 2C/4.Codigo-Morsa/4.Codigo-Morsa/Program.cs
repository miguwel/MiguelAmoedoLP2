using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Codigo_Morsa
{
    class Program
    {
        static void Main(string[] args)
        {

            int op = 3;
            Mensagem msg = new Mensagem();

            while (op != 0)
            {
                Console.WriteLine("1 - Codificar");
                Console.WriteLine("2 - Decodificar");
                Console.WriteLine("0 - Sair");

                op = int.Parse(Console.ReadLine());

                if (op == 1)
                    Console.WriteLine(msg.Codificar());

                else if (op == 2)
                    Console.WriteLine(msg.Decodificar());

            } 
        }
    }
}
