using System;

namespace AgenciaBancaria.Dominio
{
    public class Endereco
    {
        public Endereco(string logradouro, string cEP, string cidade, string estado)
        {
            Logradouro = logradouro.validarStringVazia();
            CEP = cEP.validarStringVazia();
            Cidade = cidade.validarStringVazia();
            Estado = estado.validarStringVazia();
        
        }
        public string Logradouro { get; private set; }
        public string CEP { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
    }
}