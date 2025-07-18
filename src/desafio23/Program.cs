using System.Diagnostics;

namespace Desafio23
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("digita a bagaça");
            var number = int.Parse(Console.ReadLine());

            for (var i = number; i != 0; i--)
            {
                if (number % i == 0) Console.WriteLine(i);
            }
        }
    }
}