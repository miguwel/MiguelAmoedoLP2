using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe os dados do Produto");

            Console.WriteLine("Id: ");
            int id = int.Parse(Console.ReadLine());
                
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
                
            Console.WriteLine("Preço: ");
            double preço = double.Parse(Console.ReadLine());

            Produto prod = new Produto(id, nome, preço);
            
            int i = 0;
            while (i != 4)
            {
                Console.WriteLine("1 - Repor");
                Console.WriteLine("2 - Retirar");
                Console.WriteLine("3 - Imprimir");
                Console.WriteLine("4 - Sair");

                i = int.Parse(Console.ReadLine());

                if(i == 1)
                {
                    Console.WriteLine("Quantidade ganha: ");
                    int x = int.Parse(Console.ReadLine());
                    prod.Repor(x);
                }

                if (i == 2)
                {
                    Console.WriteLine("Quantidade retirada: ");
                    int x = int.Parse(Console.ReadLine());
                    prod.Retirada(x);
                }

                if (i == 3)
                {
                    Console.WriteLine(prod.Imprimir());
                }
            }
        }
    }
}
