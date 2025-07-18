namespace Desafio18
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Digite 1 e 1000");
            var number =  int.Parse(Console.ReadLine());

            for (var i = 0; i <= number; i++)
            {
                if (i % 2 != 0) Console.Write($"\nvalor impar {i}");
            }
        }
    }
}