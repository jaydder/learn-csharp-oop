namespace Desafio19
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe o role: ");
            var role = int.Parse(Console.ReadLine());
            var values = new int[role];
            int outside = 0, inside = 0;

            for (var i = 0; i < role; i++)
            {
                Console.Write("Informe o valor: ");
                values[i] = int.Parse(Console.ReadLine());
            }
            
            foreach (var value in values)
            {
                if (value is < 10 or > 20)
                {
                    outside++;
                }
                else
                {
                    inside++;
                }
            }
            
            Console.WriteLine($"{inside} in \n{outside} out");
        }
    }
}