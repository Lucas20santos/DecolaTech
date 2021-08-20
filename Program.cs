using System;

namespace DecolaTech
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 34;
            int b = 90;
            int soma = a + b;

            Console.WriteLine($"Soma {a} + {b} = {soma}");

            if(soma >= 70)
            {
                Console.WriteLine("Média Boa");
            }
            else
            {
                Console.WriteLine("Pode Melhora");
            }
        }
    }
}
