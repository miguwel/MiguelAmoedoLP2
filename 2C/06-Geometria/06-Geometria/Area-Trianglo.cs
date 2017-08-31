using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Geometria
{
    class Triangulo
    {

        public double A { get; set; }
        public double B { get; set; }
        public int O { get; set; }

        private double area;

        public double Area
        {
            get { return area; }
        }

        private double perimetro;

        public double Perimetro
        {
            get { return perimetro; }
        }

        public double PerimetroTriangulo()
        {
            this.perimetro = A + B + Math.Sqrt((A*A)+(B*B));
            return Perimetro;
        }

        public double AreaTriangulo(double b, double H)
        {
            this.area = (B * (A * Math.Sin(O))) / 2;
            return Area;
        }

        public double AreaTriangulo(double a, double b, double cosO) 
        {
            this.area = 2 * (A + B) * Math.Cos(O);
            return Area;
        }


    }
}
