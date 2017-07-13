﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros_Hermione
{
    class Program
    {
        static void Main(string[] args)
        {
            double paghr, hrsdia, Ttotalhr = 0, TtotalDias; 
            int N, imp;
            
            Console.WriteLine("Quantos livros desta vez? ");
            N = int.Parse(Console.ReadLine());

            Livro[] livro = new Livro[N];

            Console.WriteLine("Quantas paginas por hora?");
            paghr = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantas horas por dia?");
            hrsdia = double.Parse(Console.ReadLine());


            int i = 0;
            while(i < N)
            {
                livro[i] = new Livro();

                Console.WriteLine("Titulo do Livro: ");
                livro[i].titulo = Console.ReadLine();

                Console.WriteLine("Quantidade de paginas do livro: ");
                livro[i].qtdpag = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantos dias até a devolução? ");
                livro[i].DiasAteDev = double.Parse(Console.ReadLine());

                Ttotalhr = Ttotalhr + livro[i].TempoDeLeitura(paghr);

                i++;
            }

            i = 0;
            imp = 0;
            while(i < N)
            {
                if (livro[i].TempoDeLeitura(paghr) > livro[i].DiasAteDev * hrsdia)
                {
                    Console.WriteLine("O livro '{0}' é impossivel de ser lido", livro[i].titulo);
                    imp++;
                }
                i++;
            }

            if (imp == 0)
                Console.WriteLine("Nenhum livro pode ser considerado impossivel segundo os seus critérios");

            TtotalDias = Ttotalhr / hrsdia;

            Console.WriteLine("Voce levará {0} dias para ler todos os livros", TtotalDias);

        }
    }
}
