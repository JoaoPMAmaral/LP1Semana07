namespace BetterColorSpheres
{
    public class Color
    {
        private  byte red;
        private  byte green;
        private  byte blue;
        private  byte alpha;

        public Color(byte red, byte green, byte blue, byte alpha)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            this.alpha = alpha;
        }

        public Color(byte red, byte green, byte blue)
        {
            this.red = red;
            this.green = green;
            this.blue = blue;
            alpha = 255;
        }

        public string RGB
        {
            get
            {
                return $"{red} {green} {blue}";
            }
        }
        public int Grey
        {
            get
            {
                return (red + green + blue) / 3;
            }
        }
        public string Estado
        {
            get
            {
                return $"{red} {green} {blue} {alpha}";
            }
        }
    }
}