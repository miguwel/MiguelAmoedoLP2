using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresa
{
    class Empregado : Funcionario
    {
        public string Dta_Entrada { get; set; }
        public Gerente Ger { get; set; }

        public Empregado (int reg, string dta) : base (reg)
        {
            this.Dta_Entrada = dta;
        }
    }
} 