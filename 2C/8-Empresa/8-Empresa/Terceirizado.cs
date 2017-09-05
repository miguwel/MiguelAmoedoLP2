using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresa
{
    class Terceirizado
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

        private int dta_entrada;
        public int Dta_Entrada
        {
            get { return dta_entrada; }
        }

        public int ID_gerente { get; set; }

        private string empresa_matriz;

        public string Empresa_Matriz
        {
            get { return empresa_matriz; }
        }

        public Terceirizado(int cpf, int nro, int ger, int dta, string enterprize)
        {
            this.cpf = cpf;
            nro_registro = nro;
            ID_gerente = ger;
            dta_entrada = dta;
            empresa_matriz = enterprize;
        }
    }
}
