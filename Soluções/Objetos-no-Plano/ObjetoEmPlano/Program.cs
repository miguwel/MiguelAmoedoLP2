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
            ConsoleKey comando = Console.ReadKey().Key;
            
            while (comando != ConsoleKey.Escape)
            {

                if (comando == ConsoleKey.RightArrow)
                    obj.AndDir();
                
                else if (comando == ConsoleKey.LeftArrow)
                    obj.AndEsq();

                if (comando == ConsoleKey.UpArrow)
                    obj.Subir();

                if (comando == ConsoleKey.DownArrow)
                    obj.Descer();

                Console.WriteLine(obj.Coordenadas());
                
                Console.Write("Digite comando: ");
                comando = Console.ReadKey().Key;
            }
        }
    }
}
