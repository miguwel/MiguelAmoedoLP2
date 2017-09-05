using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Empresa
{
    class Empregado
    {
        public string Nome { get; set; }

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

        public Empregado(int cpf, int nro, int ger, int dta)
        {
            this.cpf = cpf;
            nro_registro = nro;
            ID_gerente = ger;
            dta_entrada = dta;
        }        
    }
} 