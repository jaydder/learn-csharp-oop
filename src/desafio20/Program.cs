using System.Globalization;
using System.Runtime.InteropServices;

namespace Desafio12
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o teste: ");
            var quantity = int.Parse(Console.ReadLine());

            for (var i = 1; i <= quantity; i++)
            {
                
               Console.Write("Valores : ");
               string[] values = Console.ReadLine().Split(' ');

               double number = double.Parse(values[0]);
               double number2 = double.Parse(values[1]);
               double number3 = double.Parse(values[2]);
               
               double media = (number * 2 + number2 * 3 + number3 * 5) / 10;
               Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}

