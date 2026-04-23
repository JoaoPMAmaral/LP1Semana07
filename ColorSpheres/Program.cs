using System;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color cor = new Color(20,25,55,255);
            Color cor2 = new Color(65,12,200);

            //teste cores
            Console.WriteLine(cor.GetRGB());
            Console.WriteLine(cor.GetGrey());
            Console.WriteLine(cor2.GetRGB());
            Console.WriteLine(cor2.GetGrey());

            Console.WriteLine("");
            //teste esferas
            Sphere esfera = new Sphere(cor.GetRGB(),20,0);
            Sphere esfera2 = new Sphere(cor.GetRGB(),30,20);

            Console.WriteLine(esfera.GetTimesThrown());
            esfera.Throw();
            Console.WriteLine(esfera.GetTimesThrown());
            

            Console.WriteLine(esfera2.GetTimesThrown());
            esfera2.Throw();
            Console.WriteLine(esfera2.GetTimesThrown());
            esfera2.Pop();
            esfera2.Throw();
            Console.WriteLine(esfera2.GetTimesThrown());
        }
    }
}
