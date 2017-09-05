using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorMedidas
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 42;

            while (op != 0)
            {
                Console.WriteLine("1 - Kilometros para Milhas");
                Console.WriteLine("2 - Milhas para Kilometros");
                Console.WriteLine("3 - Celsius para Fahrenheit");
                Console.WriteLine("4 - Fahrenheit para Celsius");
                Console.WriteLine("5 - Kilogramas para Libras");
                Console.WriteLine("6 - Libras para Kilogramas");
                Console.WriteLine("0 - Sair");
                op = int.Parse(Console.ReadLine());

                if (op == 1)
                    Console.WriteLine(Conversor.KmParaMilha(double.Parse(Console.ReadLine())));

                else if (op == 2)
                    Console.WriteLine(Conversor.MilhaParaKm(double.Parse(Console.ReadLine())));

                else if (op == 3)
                    Console.WriteLine(Conversor.CParaF(double.Parse(Console.ReadLine())));

                else if (op == 4)
                    Console.WriteLine(Conversor.FParaC(double.Parse(Console.ReadLine())));

                else if (op == 5)
                    Console.WriteLine(Conversor.KgParaLb(double.Parse(Console.ReadLine())));

                else if (op == 6)
                    Console.WriteLine(Conversor.LbParaKg(double.Parse(Console.ReadLine())));                   
            }

        }
    }
}
