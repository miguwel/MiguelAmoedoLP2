using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    class Cliente
    {
        public int Id { get; set; }

        public int nConta { get; set; }

        private int senha;
        public int Senha
        {
            set
            {
                senha = value;
            }
        }
    }
}
