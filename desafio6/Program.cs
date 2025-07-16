using System;
using System.Globalization;
namespace Desafio06
{
    class Program
    {
        static void Main(string[] args)
        {
            double value1, value2, value3;

            value1 = 12.7;
            value2 = 10.4;
            value3 = 15.2;

            Console.WriteLine("Triangle: " + triangle(value1 , value3));
            Console.WriteLine("Circle: " + circle(value3));
            Console.WriteLine("Trapaze: " + trapeze(value1, value2, value3));
            Console.WriteLine("Square: " + square(value2));
            Console.WriteLine("Rectancle: " + rectangle(value1, value2));

        }

        static double triangle(double base_triangle, double height)
        {
            return (base_triangle * height) / 2;
        }

        static double circle(double radiu)
        {
            const double PI = 3.14159;
            return Math.Round(PI * Math.Pow(radiu, 2), 2);
        }

        static double trapeze(double lower_base, double upper_base, double height)
        {
            return (upper_base + lower_base) * height / 2;
        }

        static double square(double side)
        {
            return Math.Round(Math.Pow(side, 2), 2);
        }
        static double rectangle(double base_rectangle, double height)
        {
            return Math.Round(base_rectangle * height, 2);
        }
    }
}