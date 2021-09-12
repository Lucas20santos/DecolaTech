using System;
using poo1.classes;

namespace poo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            
            Produto p1 = new Produto(12, "farinha", 12, 15, 20, true, "12/09/2021");

            Console.WriteLine($"Produto: {p1.Nome}");
        }
    }
}
