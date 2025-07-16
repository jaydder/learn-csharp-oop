using System;

namespace Desafio10
{
    class Program
    {
        public static void Main(string [] args)
        {
            Console.WriteLine("inicial");
            var initial = int.Parse(Console.ReadLine());
            Console.WriteLine("Final");
            var final = int.Parse(Console.ReadLine());

            Console.WriteLine(diffHours(initial, final));
        }
        private static int diffHours(int hourInitial, int hourFinal)
        {
            return hourInitial < hourFinal ? hourFinal - hourInitial : 24 - hourInitial + hourFinal;
        }
    }
}

