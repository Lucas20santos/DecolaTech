using System;
using System.Collections.Generic;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Clear();

            Console.Write(":");

            string[] vet = Console.ReadLine().Split(" ");

            int X, Y;
            X = int.Parse(vet[0]);
            Y = int.Parse(vet[1]);

            for(int i = 1; i <= Y; i++)
            {
              Console.WriteLine(i);
              if(i % X == 0)
              {
                Console.WriteLine("");
              }
            }  
        }
    }
}
