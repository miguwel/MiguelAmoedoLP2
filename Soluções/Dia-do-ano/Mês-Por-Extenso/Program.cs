using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mês_Por_Extenso
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            string dta, mes;

            dta = Console.ReadLine();

            dia = int.Parse(dta.Substring(0, 2));

            if (dia < 10)
                mes = dta.Substring(5, 4);

            else
                mes = dta.Substring(6, 4);


            if (mes == "feve" || mes == "Feve")
                dia = dia + 31;
                
            else if (mes == "març" || mes == "Març")
                dia = dia + 31 + 28;
                
            else if (mes == "abri" || mes == "Abri")
                dia = dia + (2 * 31) + 28;
                
            else if (mes == "maio" || mes == "Maio")
                dia = dia + 30 + (2 * 31) + 28;
                
            else if (mes == "junh" || mes == "Junh")
                dia = dia + 30 + (3 * 31) + 28;
                
            else if (mes == "julh" || mes == "Julh")
                dia = dia + (2 * 30) + (3 * 31) + 28;
                
            else if (mes == "agos" || mes == "Agos")
                dia = dia + (2 * 30) + (4 * 31) + 28;
                
            else if (mes == "sete" || mes == "Sete")
                dia = dia + (2 * 30) + (5 * 31) + 28;
                
            else if (mes == "outu" || mes == "Outu")
                dia = dia + (3 * 30) + (5 * 31) + 28;
                
            else if (mes == "nove" || mes == "Nove")
                dia = dia + (3 * 30) + (6 * 31) + 28;
                
            else if (mes == "deze" || mes == "Deze")
                dia = dia + (4 * 30) + (6 * 31) + 28;

            Console.WriteLine("{0}º", dia);

        }
    }
}
