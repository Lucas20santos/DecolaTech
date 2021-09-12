using System;

namespace Classes.heranca
{
    public class Ponto
    {
        public int x, y;

        private int distancia;

        public Ponto(int x, int y)
        {
            Console.WriteLine("Ponto Inicial Criado!!!");
            this.x = x;
            this.y = y;
        }

        protected double CalcularDistancia(int x1, int y1)
        {
            return Math.Sqrt(Math.Pow((x1 - this.x), 2) + Math.Pow((y1 - this.y), 2));
        }
        protected void CalcularDistancia2()
        {
            // faz alguma coisa...
        }
        public virtual void CalcularDistancia3()
        {
            // faz alguma coisa
        }


    }
}