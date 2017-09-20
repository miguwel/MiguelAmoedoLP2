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
            nro_registro = reg;
        }

        public string Nome { get; set; }

        public double Salario { get; set; }

        public string Email { get; set; }

        private int nro_registro;
        public int Nro_registro
        {
            get { return nro_registro; }
        }

        private string cpf;
        public string CPF 
        {
            get { return cpf; } 
        }
    }
}
