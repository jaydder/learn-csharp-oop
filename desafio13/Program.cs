using System;

namespace Desafio13
{
  class Program
  {
    public static void Main(String[] args)
    {
      double x, y;
      
      x = 4.5;
      y = -2.2;
      Console.WriteLine(Coordenate(x,y));
      
      x = 0.1;
      y = 0.1;
      Console.WriteLine(Coordenate(x,y));
      
      x = 0.0;
      y = -0.0;
      Console.WriteLine(Coordenate(x,y));

    }

    private static string Coordenate(double x, double y) 
    {
      
      if (x > 0 && y > 0)
      {
        return "Q1";
      } 
      else if (x < 0 && y > 0)
      {
        return "Q2";
      }
      
      else if (x < 0 && y > 0)
      {
        return "Q3";
      }
      else if (x > 0 && y < 0)
      {
        return "Q4";
      }
      else
      {
        return "Origem";
      }
    }
  }
}