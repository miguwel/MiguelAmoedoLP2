using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes_por_Extenso
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string m;
            int dia, mes, ano;
            dia = int.Parse(s.Substring(0, 2));
            mes = int.Parse(s.Substring(3, 2));
            ano = int.Parse(s.Substring(6, 4));

            switch (mes)
            {
                case 1: { m = "janeiro"; break; }
                case 2: { m = "fevereiro"; break; }
                case 3: { m = "março"; break; }
                case 4: { m = "abril"; break; }
                case 5: { m = "maio"; break; }
                case 6: { m = "junho"; break; }
                case 7: { m = "julho"; break; }
                case 8: { m = "agosto"; break; }
                case 9: { m = "setembro"; break; }
                case 10: { m = "outubro"; break; }
                case 11: { m = "novembro"; break; }
                case 12: { m = "dezembro"; break; }
                default: { m = "OPA, FOI TROLLED"; break; }
            }

            Console.WriteLine(" {0} de {1} do ano {2}", dia, mes, ano);
        }
    }
}
