using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competiçao_de_Corrida
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            string vencedor;
            double TempoVencendor;

            Competidor[] comp = new Competidor[n];
            double[] tempoOf = new double[n];

            int i = 0;
            while (i < n)
            {
                comp[i] = new Competidor();

                comp[i].nome = Console.ReadLine();
                comp[i].t1 = Double.Parse(Console.ReadLine());
                comp[i].t2 = Double.Parse(Console.ReadLine());
                comp[i].t3 = Double.Parse(Console.ReadLine());
                tempoOf[i] = comp[i].TempoOficial();

                i++;
            }

            TempoVencendor = tempoOf[0];
            vencedor = comp[0].nome;
            i = 0;
            while (i < n)
            {
                if (tempoOf[i] < TempoVencendor)
                {
                    TempoVencendor = tempoOf[i];
                    vencedor = comp[i].nome;
                }

                i++;
            }

            Console.WriteLine("O vencedor é {0} com o tempo de {1}", vencedor, TempoVencendor);
        }
    }
}
