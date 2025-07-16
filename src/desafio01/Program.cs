using System;
namespace Desafio01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Area X");
            // double x_a = Double.Parse(Console.ReadLine());
            // double x_b = Double.Parse(Console.ReadLine());
            // double x_c = Double.Parse(Console.ReadLine());

            // Console.WriteLine("Area y");
            // double y_a = Double.Parse(Console.ReadLine());
            // double y_b = Double.Parse(Console.ReadLine());
            // double y_c = Double.Parse(Console.ReadLine());

            double x_a, x_b, x_c;
            x_a = 3.00;
            x_b = 4.00;
            x_c = 5.00;

            double y_a, y_b, y_c;
            y_a = 7.50;
            y_b = 4.50;
            y_c = 4.02;

            double area_x = Area(x_a, x_b, x_c);
            double area_y = Area(y_a, y_b, y_c);

            string result = area_x > area_y ? "X Maior" : "Y Maior";
            Console.WriteLine(result);


        }

        static double Area(double a, double b, double c)
        {
            double p = (a + b + c) / 2;

            return  Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }
    }
}