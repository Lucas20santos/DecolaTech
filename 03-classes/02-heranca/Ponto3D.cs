using System;

namespace Classes.heranca
{
    public class Ponto3D : Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z= z;
            CalcularDistancia();
        }

        private void CalcularDistancia()
        {
            throw new NotImplementedException();
        }

        public override void CalcularDistancia3()
        {
            base.CalcularDistancia3();
        }
    }
}