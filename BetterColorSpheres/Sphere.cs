namespace BetterColorSpheres
{
    public class Sphere
    {
        private readonly string cor;
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
        public string TimesThrown
        {
            get
            {
                if(raio != 0)
                {
                    return $"A bola foi atirada {vezesAtirada} vezes";
                }
                else
                {
                    return "A bola foi furada!";
                }
            }
        }
        public string Estado
        {
            get
            {
                return $"{cor} {raio} {vezesAtirada}";
            }
        }
    }
}