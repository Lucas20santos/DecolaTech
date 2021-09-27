using System;
using System.IO;
using System.Text;


namespace DIO.Series
{
    public class BancoDados
    {
        private bool arquivoCriado { get; set; }
        private string nomeArquivo { get; set; }
        private string caminhoArquivo { get; set; }
        private int id { get; set; }

        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Ano { get; set; }
        public bool Excluido { get; set; }

        public BancoDados(string nomeArquivo, string caminhoArquivo)
        {
            Console.WriteLine("OK");
            this.arquivoCriado = true;
            this.nomeArquivo = nomeArquivo;
            this.caminhoArquivo = caminhoArquivo + nomeArquivo;
        }

        public void criarArquivo()
        {
            this.arquivoCriado = true;    
            StreamWriter file;
            file = File.CreateText(this.caminhoArquivo);
            file.Close();
        }
        public StreamWriter abrirArquivo()
        {
            StreamWriter file;
            
            file = File.AppendText(this.caminhoArquivo);
            return file;
        }

        public void insereNoBanco(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.id = id;
            this.Genero = genero;
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Ano = ano;
            this.Excluido = true;

            StreamWriter file = abrirArquivo();
        
            file.WriteLine("filme: " + this.id);
            file.WriteLine("Genero: " + this.Genero);
            file.WriteLine("Título: " + this.Titulo);
            file.WriteLine("Ano: " + this.Ano);
            file.WriteLine("Descrição: " + this.Descricao);
            file.WriteLine("Disponível: " + this.Excluido);
            file.WriteLine("------------------------------------");
            file.Close();
        }
    }
}