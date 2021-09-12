using System;

namespace poo1.classes
{
    public class Produto
    {
        private int codigo;
        private string nome;
        private decimal preco_compra;
        private decimal preco_venda;
        private int quantidade_estoque;
        private bool ativo;
        private string data_cadastro;

        public int Codigo { get => codigo; set => codigo = value; }
        public string Nome { get => nome; set => nome = value; }
        public decimal Preco_compra { get => preco_compra; set => preco_compra = value; }
        public decimal Preco_venda { get => preco_venda; set => preco_venda = value; }
        public int Quantidade_estoque { get => quantidade_estoque; set => quantidade_estoque = value; }
        public bool Ativo { get => ativo; set => ativo = value; }
        public string Data_cadastro { get => data_cadastro; set => data_cadastro = value; }

        public Produto(int codigo, string nome, decimal preco_compra, decimal preco_venda, int quantidade_estoque, bool ativo, string data_cadastro)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Preco_compra = preco_compra;
            this.Preco_venda = preco_venda;
            this.Quantidade_estoque = quantidade_estoque;
            this.Ativo = ativo;
            this.Data_cadastro = data_cadastro;
        }

        public void inserir() { }
        public void alterar() { }
        public void excluir() { }
        public void pesquisar() { }

    }
}
