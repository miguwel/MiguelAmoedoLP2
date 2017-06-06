using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            obj.x = x;
            obj.y = y;

            Console.Write("Digite comando: ");
            
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {

                if (direcao == ConsoleKey.RightArrow)
                    obj.AndDir();
              
                Console.WriteLine(obj.Coordenadas());
            }
        }
    }
}
