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

        private string nome;
        public string Nome 
        {
            get { return nome; } 
        }
        
        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
        }

        public double Preço { get; set; }

        public string Marca { get; set; }

        public void Repor(int qtd)
        {
            quantidade += qtd;
        }

        public void Retirada(int qtd)
        {
            if (quantidade >= qtd)
                quantidade -= qtd;
            

            else
                throw new Exception("Uma retirada não pode exceder a quantidade em estoque atual");
        }

        public string Imprimir()
        {
            string x = Preço.ToString("0.00");
            return String.Format("Produto {0} : {1} - R$ {2} - Estoque : {3}", id, nome, x, quantidade);
        } 

        public Produto(int id, string nome, double preço)
        {
            this.id = id;
            this.nome = nome;
            this.Preço = preço;
            this.quantidade = 0;
        }
    }
}
