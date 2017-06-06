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

            Competidor [] comp = new Competidor [n];
            double [] tempoOf = new double [n];

            int menorTempo;

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

            //*TESTE ====> Console.WriteLine("O tempo oficial de {0} é {1} segundos", comp.nome, tempoOf);

        }
    }
}
