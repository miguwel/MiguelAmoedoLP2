using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresa
{
    class Empregado : Funcionario
    {
        private string dta_entrada;
        public string Dta_Entrada 
        {
            get { return dta_entrada; }
        }
        public Gerente Ger { get; set; }

        public Empregado (int reg, string dta) : base (reg)
        {
            this.dta_entrada = dta;
        }
    }
} 