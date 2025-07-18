namespace Desafio21
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("digita valor: ");
            int value = int.Parse(Console.ReadLine());

            for (int i = 0; i < value; i++)
            {
                
                string[] numbers = Console.ReadLine().Split(' ');
                double number = double.Parse(numbers[0]);
                double number2 = double.Parse(numbers[1]);

                if (number2 == 0)
                {
                    Console.WriteLine("Divisão por zero");
                }
                else
                {
                    Console.WriteLine(number / number2);
                }
                

            }
        }
    }
}