using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int H = 600, W = 800;

            Obj2D obj = new Obj2D();
            
            Console.Write("Digite X inicial: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Digite Y inicial: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Digite comando: ");

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                
                ConsoleKey direcao = Console.ReadKey().Key;
               
                if (direcao == ConsoleKey.RightArrow)
                    obj.AndDir();

                else if (direcao == ConsoleKey.LeftArrow)
                    obj.AndEsq();

                else if (direcao == ConsoleKey.UpArrow)
                    obj.Subir();

                else if (direcao == ConsoleKey.DownArrow)
                    obj.Descer();

                Console.WriteLine(obj.Coordenadas());
            }
        }
    }
}
