using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Produtos
{
    class Produto
    {
        private int id;

        public int Id
        {
            get { return id; }
        }

        public string Nome { get; set; }

        public double Preço { get; set; }

        private int quantidade;
        public int Quantidade
        {
            get { return id; }
        }

        public void Repor(int qtd)
        {
            quantidade += qtd;
        }

        public Produto(int id, string nome, double preço)
        {
            this.id = id;
            this.Nome = nome;
            this.Preço = preço;
            this.quantidade = 0;
        }
    }
}
