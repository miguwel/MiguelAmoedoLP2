using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Obj2D
    {
        public int x, y;

        public void AndDir() {
            x++;
        }

        public void AndEsq()
        {
            x--;
        }

        public void Descer()
        {
            y++;
        }

        public void Subir()
        {
            y--;
        }

        public string Coordenadas() {
            return String.Format("({0},{1})", x, y);
        }
    }
}
