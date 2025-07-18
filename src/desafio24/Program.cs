namespace Desafio24
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("digita a bagaça");
            var number = int.Parse(Console.ReadLine());

            for (var i = 1; i <= number; i++)
            {
                Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            }
        }
    }
}