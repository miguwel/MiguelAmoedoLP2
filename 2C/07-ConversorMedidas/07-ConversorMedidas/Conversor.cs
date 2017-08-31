using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ConversorMedidas
{
    static class Conversor
    {
        public static double KgParaG(double x)
        {
            return x * 1000;
        }

        public static double GParaKg(double x)
        {
            return x / 1000;
        }

        public static double KgParaT(double x)
        {

            return x * 1000;
        }

        public static double TParaKg(double x)
        {
            return x / 1000;
        }

        public static double KgParaLb(double x)
        {
            return x * 2.2046;
        }

        public static double LbParaKg(double x)
        {
            return x / 2.2046;
        }

        public static double CParaF(double x)
        {
            return x * 1.8 + 32;
        }

        public static double FParaC(double x)
        {
            return (x - 32) / 1.8;
        }

        public static double CParaK(double x)
        {
            return x + 273;
        }

        public static double KParaC(double x)
        {
            return x - 273;
        }

        public static double FParaK(double x)
        {
            x = FParaC(x);
            return CParaK(x);
        }

        public static double KParaF(double x)
        {
            x = KParaC(x);
            return CParaF(x);
        }

        public static double MParaKm(double x)
        {
            return x / 1000;
        }

        public static double KmParaM(double x)
        {
            return x * 1000;
        }

        public static double MParaPes(double x)
        {
            return x * 3.2808;
        }

        public static double PesParaM(double x)
        {
            return x / 3.2808;
        }

        public static double PolParaPes(double x)
        {
            return x * 0.083333;
        }

        public static double PesParaPol(double x)
        {
            return x * 12.000;
        }

        public static double MParaPol(double x)
        {
            return x * 39.370;
        }

        public static double PolParaM(double x)
        {
            return x / 39.370;
        }

        public static double MilhaParaKm(double x)
        {
            return x / 0.62137;
        }

        public static double KmParaMilha(double x)
        {
            return x * 0.62137;
        }

        
    }
}
