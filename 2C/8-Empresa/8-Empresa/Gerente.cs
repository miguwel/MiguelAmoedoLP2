using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresa
{
    class Gerente
    {
        public int Nome { get; set; }

        public double Salario { get; set; }

        public string Email { get; set; }

        private int nro_registro;

        public int Nro_registro
        {
            get { return nro_registro; }
        }

        private int cpf;

        public int CPF
        {
            get { return cpf; }
        }

        public double Bonus { get; set; }

        public Gerente(int cpf, int nro, double bonus)
        {
            this.cpf = cpf;
            nro_registro = nro;
            Bonus = bonus;
        }
    }
}
