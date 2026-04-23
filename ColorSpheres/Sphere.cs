using System.Runtime.Intrinsics.X86;

namespace ColorSpheres
{
    public class Sphere
    {
        private string cor;
        private int raio;
        private int vezesAtirada;
        public Sphere(string cor, int raio, int vezesAtirada)
        {
            this.cor = cor;
            this.raio = raio;
            this.vezesAtirada = vezesAtirada;

            this.vezesAtirada = 0;
        }

        public void Pop()
        {
            this.raio = 0;
        }
        public void Throw()
        {
            vezesAtirada += 1;
        }
        public string GetTimesThrown()
        {
            if(raio != 0)
            {
                return $"A bola foi atirada {vezesAtirada} vezes";
            }else
            {
                return "A bola foi furada!";
            }
        }
    }
}