using System;

namespace _02_instrucoes
{
    class Program
    {
        static void Declaracoes()
        {
            int a;
            int b =2, c = 3;
            const int d = 4;
            a = 1;
            Console.WriteLine(a + b + c + d);
        }

        static void InstrucaoIf(String[] args)
        {
            Console.WriteLine("Instração IF-Else");
            if(args.Length == 0)
            {
                Console.WriteLine("Nenhum argumento");
            }
            else if(args.Length == 1)
            {
                Console.WriteLine("Um argumento");
            }
            else 
            {
                Console.WriteLine($"{args.Length} argumentos");
            }
        }
        
        static void InstrucaoS(String[] args)
        {

            int numeroDeArgumentos = args.Length;
            
            Console.WriteLine("Instração Switch-Case");
            switch (numeroDeArgumentos)
            {
                case 0:
                    Console.WriteLine("Nenhum argumento");
                    break;
                case 1:
                    Console.WriteLine("Um argumento");
                    break;
                
                default:
                    Console.WriteLine($"{args.Length} argumentos");
                    break;
            }
        }

        static void InstrucaoWhile(String[] args)
        {
            Console.WriteLine("Instração While");
            int i = 0;
            while(i < args.Length)
            {
                Console.WriteLine(args[i]);
                i++;
            }
        }

        static void InstrucaoDo(String[] args)
        {
            Console.WriteLine("Instração Do-While");
            int i = 0;
            do
            {
                Console.WriteLine(args[i]);
                i++;
            }
            while(i < args.Length);
        }

        static void InstrucaoFor(String[] args)
        {
            Console.WriteLine("Instração For");

            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoForeach(String[] args)
        {
            Console.WriteLine("Instrução Foreach");

            foreach (var item in args)
            {
                Console.WriteLine(item);                
            }
        }

        static void InstrucaoBreak(String[] args)
        {
            Console.WriteLine("Instrução Break");
            
            int i = 1;
            while(true)
            {
                Console.WriteLine(i);
                if(i > 10)
                {
                    break;
                }
            }
        }
        
        static void InstrucaoContinue(String[] args)
        {
            Console.WriteLine("Instrução Continue");

            for(int i = 0; i < args.Length; i++)
            {
                if(args[i].StartsWith("/"))
                {
                    continue;
                }
                Console.WriteLine(args[i]);
            }
        }

        static void InstrucaoReturn(String[] args)
        {

            Console.WriteLine("Instrução Return");

            int Somar(int a, int b)
            {
                return a + b;
            }

            if(args.Length >= 1)
            {
                // se o meu args for igual ou maior que 1,
                // eu quero que meu programa retorne desse
                // ponto e não execulte mais nada.
                return;
            }

            Console.WriteLine(Somar(1, 2));
            Console.WriteLine(Somar(3, 4));
        }

        static void InstrucaoTryCatchFinallyThrow(String[] args)
        {
            double Dividir(double x, double y)
            {
                if(y ==  0)
                {
                    throw new DivideByZeroException();
                }
                return x / y;
            }
            double x, y;
            
            try
            {
                if(args.Length != 2)
                {
                    throw new InvalidOperationException("Informe 2 numeros");

                     x = double.Parse(args[0]);
                     y = double.Parse(args[1]);
                    Console.WriteLine(Dividir(x, y));
                }
            }
            catch(InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine($"Menssagem: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Ok");
            }
            
        }

        static void InstrucaoUsing()
        {
            using (System.IO.TextWriter w = System.IO.File.CreateText("teste.txt"))
            {
                w.WriteLine("Line 1");
                w.WriteLine("Line 2");
                w.WriteLine("Line 3");
            }

        }

        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Hello World!");
        }

    }
    
}
