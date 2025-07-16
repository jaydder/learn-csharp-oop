using System;
using System.Globalization;
namespace Desafio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DIgite a bagaça");
            int value = int.Parse(Console.ReadLine());


            String result = value < 0 ? "Negativo" : "Positivo";

            Console.WriteLine(result);

        }
    }
}