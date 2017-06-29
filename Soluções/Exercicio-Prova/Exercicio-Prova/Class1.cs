using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Prova
{
    class Questao
    {
        public int tomA, tomB, tomC, tomD, tomE, nresp, ninv;
        public string resp;

        public void Resposta()
        {

            nresp = 0;
            ninv = 0;
            if (tomA <= 100)
            {
                resp = "A";
                nresp++;
            }
            else if (tomA <= 155)
                ninv++;

            if (tomB <= 100)
            {
                resp = "B";
                nresp++;
            }
            else if (tomB <= 155)
                ninv++;

            if (tomC <= 100)
            {
                resp = "C";
                nresp++;
            }
            else if (tomC <= 155)
                ninv++;

            if (tomD <= 100)
            {
                resp = "D";
                nresp++;
            }
            else if (tomD <= 155)
                ninv++;

            if (tomE <= 100)
            {
                resp = "E";
                nresp++;
            }
            else if (tomE <= 155)
                ninv++;

            if (nresp != 1 || ninv != 0)
                Console.WriteLine("*");

            else
                Console.WriteLine(resp);
        }
    }
}
