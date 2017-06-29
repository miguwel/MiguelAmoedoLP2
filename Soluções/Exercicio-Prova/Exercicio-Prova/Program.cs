using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, N = Int32.Parse(Console.ReadLine());

            Questao[] quest = new Questao[N];
            i = 0;
            while (i < N)
            {
                quest[i] = new Questao();

                quest[i].tomA = Int32.Parse(Console.ReadLine());
                quest[i].tomB = Int32.Parse(Console.ReadLine());
                quest[i].tomC = Int32.Parse(Console.ReadLine());
                quest[i].tomD = Int32.Parse(Console.ReadLine());
                quest[i].tomE = Int32.Parse(Console.ReadLine());

                i++;
            }

            i = 0;
            while (i < N)
            {
                quest[i].Resposta();
                i++;
            }
        }
    }
}
