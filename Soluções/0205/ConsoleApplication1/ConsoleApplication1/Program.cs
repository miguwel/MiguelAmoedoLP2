using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public struct Carro
        {
            public string modelo;
            public double cv;
            public double km;
        }

        static void Main(string[] args)
        {
             Carro Car;

            Console.WriteLine("Quantidade de carros");
            int N = Int32.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Car.modelo = Console.ReadLine();
                Car.km = Double.Parse(Console.ReadLine());
                Car.cv = Double.Parse(Console.ReadLine());

                Console.WriteLine(Classificar(Car));
            }
        }

        public static string Classificar(Carro c)
        {
            string pot, uso;

            if (c.km <= 5000)
                uso = "Novo";
            else if (c.km <= 30000)
                uso = "Seminovo";
            else
                uso = "Velho";

            if (c.cv < 120)
                pot = "Popular";
            else if (c.cv < 200)
                pot = "Forte";
            else
                pot = "Potente";

            return String.Format("{0} - {1} - {2}", c.modelo, uso, pot); 

        }
     }
}
