using System;

namespace DIO.Series
{
    public class Carros: EntidadeBase
    {
        // Atributos
        private Modelos modelos { get; set; }
        private string Descricao { get; set; }
        private float preco {get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }
        
        // método construtor
        public Carros(int id, Modelos carros, float preco, int ano, string descricao)
        {
            this.Id = id;
            this.modelos = carros;
            this.Descricao = descricao;
            this.Ano = ano;
            this.preco = preco;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Modelo: " + this.modelos + Environment.NewLine;
            retorno += "Preço: " + this.preco + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "excluído: " + this.Excluido + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            return retorno;

        }

        public Modelos retornaModelo()
        {
            return this.modelos;
        }

        public int retornaId()
        {
            return this.Id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }   
    }
}