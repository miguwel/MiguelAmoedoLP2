using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ProvaRec
{
    class Program
    {
        static void Main(string[] args)
        {
            TempC temp = new TempC();
            
            int op = 42;

            while (op != 0)
            {
                Console.WriteLine("1 - Nova Temperatura");
                Console.WriteLine("2 - Para Fahrenheit");
                Console.WriteLine("3 - Para Kelvin");
                Console.WriteLine("0 - Sair");

                op = int.Parse(Console.ReadLine());

                if(op == 1)
                    temp.valor = double.Parse(Console.ReadLine());

                if(op == 2)
                    Console.WriteLine(temp.EmF());

                if(op == 3)
                    Console.WriteLine(temp.EmK());          
            }
        }
    }
}
