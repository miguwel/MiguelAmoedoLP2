using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercícioRevisão_Etapas
{
    class Program
    {
            public struct Carro
            {
                public string modelo;
                public double cv;
                public double km;
                public string cor;
                public string fabricante;
                public int anoFab;
            }

            static void Main(string[] args)
            {
                int n = int.Parse(Console.ReadLine());
                Carro[] Car = new Carro[n];

                for (int i = 1; i <= n; i++)
                {
                    Car[i].modelo = Console.ReadLine();
                    Car[i].km = Double.Parse(Console.ReadLine());
                    Car[i].cv = Double.Parse(Console.ReadLine());
                    Car[i].cor = Console.ReadLine();
                    Car[i].fabricante = Console.ReadLine();
                    Car[i].anoFab = Int32.Parse(Console.ReadLine());
                }
               
                for(int i=0; i < n; i++)
                    Console.WriteLine(Classificar(Car[i]));
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

            public static void AterarModelo (Carro c)
            {
                c.km = Double.Parse(Console.ReadLine());
            }

            public static void AterarCor (Carro c)
            {
                c.cor = Console.ReadLine();
            }

            public static int CalcularTaxaDeUso (Carro c)
            {
                int anoHJ, uso;
                
                anoHJ = Int32.Parse(Console.ReadLine());
                uso = anoHJ - c.anoFab;
                return uso;
            }

     }

 }


