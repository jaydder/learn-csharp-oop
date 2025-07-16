namespace Desafio09;
class Program
{
    static void Main(string[] args)
    { 
        int x, y;
        Console.WriteLine("X: ");
        x = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Y: ");
        y = int.Parse(Console.ReadLine());
        
        var result = y % x == 0 || x % y == 0 ? "Multiplo" : "Não Multiplo";
        Console.WriteLine(result);
        
    }
}