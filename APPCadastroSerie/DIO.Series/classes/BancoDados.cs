using System;
using System.IO;

namespace DIO.Series
{
    public class BancoDados
    {
        private bool arquivoCriado { get; set; }
        private string nomeArquivo { get; set; }
        private string caminhoArquivo { get; set; }
        private int id { get; set; }
        public Modelos Carros { get; set; }
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

        public void insereNoBanco(int id, Modelos carros, string descricao)
        {
            this.id = id;
            this.Carros = carros;
            this.Descricao = descricao;
            this.Excluido = true;

            StreamWriter file = abrirArquivo();

            file.WriteLine("------------------------------------");
            file.WriteLine("Id: " + this.id);
            file.WriteLine("Genero: " + this.Carros);
            file.WriteLine("Descrição: " + this.Descricao);
            file.WriteLine("Disponível: " + this.Excluido);
            file.Close();
        }

        public void listarCarros()
        {
            StreamReader file;
            file = File.OpenText(this.caminhoArquivo);
            while(file.EndOfStream != true)
            {
                string linha = file.ReadLine();
                Console.WriteLine(linha);
            }
        }
    }
}