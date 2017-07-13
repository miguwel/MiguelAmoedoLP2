using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livros_Hermione
{
    class Livro
    {
        public string titulo;
        public double qtdpag, DiasAteDev;

        public double TempoDeLeitura(double paghr)
        {
            return qtdpag / paghr;
        }
    }
}
