using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresa
{
    class Gerente : Funcionario
    {
        public double Bonus { get; set; }
        public int Setor { get; set; }

        public Gerente(int reg, int setor) : base (reg)
        { 
            this.Setor = setor;
        }
    }
}
