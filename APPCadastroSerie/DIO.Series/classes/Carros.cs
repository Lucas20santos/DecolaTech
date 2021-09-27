using System;

namespace DIO.Series
{
    public class Carros: EntidadeBase
    {
        // Atributos
        private Modelos modelos { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }
        
        // método construtor
        public Carros(int id, Modelos carros, string descricao)
        {
            this.id = id;
            this.modelos = carros;
            this.Descricao = descricao;
            this.Excluido = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Modelo: " + this.modelos + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "excluído: " + this.Excluido + Environment.NewLine;
            return retorno;

        }

        public Modelos retornaModelo()
        {
            return this.modelos;
        }

        public int retornaId()
        {
            return this.id;
        }

        public void Excluir()
        {
            this.Excluido = true;
        }
        
    }
}