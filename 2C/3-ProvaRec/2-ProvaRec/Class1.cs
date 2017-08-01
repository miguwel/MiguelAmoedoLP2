using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ProvaRec
{
    class TempC
    {
        public double valor;

        public double EmF()
        {
            return 1.8 * valor + 32;
        }

        public double EmK()
        {
            return valor + 273;
        }
    }
}
