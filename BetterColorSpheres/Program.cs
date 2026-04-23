using System;

namespace BetterColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Color cor = new Color(20,25,55,255);
            Color cor2 = new Color(65,12,200);

            //teste cores
            Console.WriteLine(cor.RGB);
            Console.WriteLine(cor.Grey);
            Console.WriteLine(cor2.RGB);
            Console.WriteLine(cor2.Grey);

            Console.WriteLine("");
            //teste esferas
            Sphere esfera = new Sphere(cor.RGB,20,0);
            Sphere esfera2 = new Sphere(cor.RGB,30,20);

            Console.WriteLine("Esfera 1");
            Console.WriteLine(esfera.TimesThrown);
            esfera.Throw();
            Console.WriteLine(esfera.TimesThrown);
            Console.WriteLine(esfera.Estado);
            

            Console.WriteLine("Esfera 2");
            Console.WriteLine(esfera2.TimesThrown);
            esfera2.Throw();
            Console.WriteLine(esfera2.TimesThrown);
            esfera2.Pop();
            esfera2.Throw();
            Console.WriteLine(esfera2.TimesThrown);
            Console.WriteLine(esfera2.Estado);
        }
    }
}