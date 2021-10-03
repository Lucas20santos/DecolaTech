using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgenciaBancaria.Dominio
{
    public class Cliente
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public Endereco Endereco { get; private set; }
        
        // Endereço do Cliente
        
        public Cliente(string nome, string cPF, string rG, Endereco endereco)
        {

            Nome = nome.validarStringVazia();
            CPF = cPF.validarStringVazia();
            RG = rG.validarStringVazia();
            Endereco = endereco ?? throw new Exception("Endereço deve ser informado.");
        }

    }
}