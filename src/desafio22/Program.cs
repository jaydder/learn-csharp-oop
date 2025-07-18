namespace Desafio22
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("numero: ");
            int number = int.Parse(Console.ReadLine());
            var result = 1;
            
            for(int i = 1; i <= number; i ++)
            {
               result *= i; 
            }
            
            Console.WriteLine(result);
        }
    }
}