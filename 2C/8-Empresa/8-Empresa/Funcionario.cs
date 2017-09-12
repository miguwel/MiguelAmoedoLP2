using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresa
{
    class Funcionario
    {
        public Funcionario (int reg)
        {
            Nro_registro = reg;
        }

        public string Nome { get; set; }

        public double Salario { get; set; }

        public string Email { get; set; }

        public int Nro_registro { get; set; }

        public string CPF { get; set; }
    }
}
