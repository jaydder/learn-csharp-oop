using System;
using System.Globalization;
namespace Desafio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int code, quantity;
            double value, total1, total2;

            code = 13;
            quantity = 2;
            value = 15.30;

            total1 = resume(quantity, value);

            code = 161;
            quantity = 4;
            value = 5.20;


            total2 = resume(quantity, value);

            Console.WriteLine("Total:" + Math.Round(total1 + total2, 2));

        }

        static double resume(int quantity, double value)
        {
            return Math.Round(quantity * value, 2);
        
        }
    }
}