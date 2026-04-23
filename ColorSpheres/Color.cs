namespace ColorSpheres
{
    public class Color
    {
        private readonly byte red;
        private readonly byte green;
        private readonly byte blue;
        private readonly byte alpha;
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

        public string GetRGB()
        {
            return $"{red} {green} {blue}";
        }

        public int GetGrey()
        {
            return (red + green + blue) / 3;
        }
        public string Estado()
        {
            return $"{red} {green} {blue} {alpha}";
        }
    }
}