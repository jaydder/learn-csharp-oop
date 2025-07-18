using System;
using System.Globalization;

namespace Desafio14
{
  class Program
  {
    public static void Main(String[] args)
    {
      double income = 0.0;
      income = 3002.00;
      Console.WriteLine(calculate_tax(income));
      
      income = 1701.12;
      Console.WriteLine(calculate_tax(income));
      
      income = 4520.00;
      Console.WriteLine(calculate_tax(income));
    }

    static double calculate_tax(double income)
    {
      const double EIGHT_PERCENT = 1000 * 0.08;
      const double EIGHTEEN_PERCENT = 1500 * 0.18;
      
      return income switch
      {
        < 2000.00 => 0.0,
        < 3000.00 => (income - 2000.00) * 0.08,
        < 4500.00 => (income - 3000.00) * 0.18 + EIGHT_PERCENT,
        _ => (income - 4500.00) * 0.28 + EIGHT_PERCENT +  EIGHTEEN_PERCENT,
        
      };
    } 
  }
}