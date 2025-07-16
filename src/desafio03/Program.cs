using System;
using System.Globalization;
namespace Desafio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d;
            a = 5;
            b = 6;
            c = 7;
            d = 8;

            double difference = diff(a , b , c , d);
            Console.WriteLine(difference);

        }

        static int diff(int a, int b, int c, int d)
        {
            int produto_ab = a * b;
            int produto_cd = c * d;

            return produto_ab - produto_cd;
        }
    }
}