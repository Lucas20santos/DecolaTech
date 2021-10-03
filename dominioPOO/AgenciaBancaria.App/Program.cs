using System;
using AgenciaBancaria.Dominio;

namespace AgenciaBancaria.App
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
             
             Endereco endereco = new Endereco("rua falsa", "00000-000", "recife", "PE");

             Cliente cliente = new Cliente(nome:"lucas",cPF:"000.000.000-00", rG:"0.000.000", endereco:endereco);
            }
            catch (Exception ex)
            {
                
                Console.WriteLine(ex.Message);
            }
        }
    }
}
