using System;
using System.Globalization;
namespace Desafio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 100.64;
            double area = Area(x);
            Console.WriteLine(area);

        }

        static double Area(double diametro) 
        {
            double raio = diametro / 2;
            return Math.Round(3.14159 * Math.Pow(raio,2), 4);
        }
    }
}