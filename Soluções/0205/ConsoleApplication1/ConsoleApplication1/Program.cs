using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double cv, km;
            string modelo, pot, uso;

            Console.WriteLine("Quantidade de carros");
            int N = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                modelo = Console.ReadLine();
                km = Double.Parse(Console.ReadLine());
                cv = Double.Parse(Console.ReadLine());

                if (km <= 5000)
                    uso = "Novo";
                else if (km <= 30000)
                    uso = "Seminovo";
                else
                    uso = "Velho";

                if (cv < 120)
                    pot = "Popular";
                else if (cv < 200)
                    pot = "Forte";
                else
                    pot = "Potente";

                Console.WriteLine("{0} - {1} - {2}", modelo, pot, uso);
            }
        }
    }
}
