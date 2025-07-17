using System;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Desafio12
{
  class Program
  {
    public static void Main(String[] args)
    {
      Console.WriteLine("Digita a bagaça");
      double value = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture );
      
      Console.WriteLine(Interval(value));
      
    }

    private static string Interval(double number)
    {
      Console.Write(number);
      return number switch
      {
        < 0.00 or > 100.00 => "Fora do Escopo",
        <= 25.00 => "Intervalo [0,25]",
        <= 50.00 => "Intervalo (25,50]",
        <= 75.00 => "Intervalo (50,75]",
        _ => "Intervalo (75,100]"
      };
    }
  }
}

