using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresa
{
    class Terceirizado : Empregado
    {
        public string Empresa_Matriz { get; set; }

        public Terceirizado (int reg, string dta, string empresa) : base (reg, dta)
        {
            this.Empresa_Matriz = empresa;
        }
    }
}
