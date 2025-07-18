using System;

namespace Desafio16
{
  class Program
  {
    public static void Main(String[] args)
    {
      while (true)
      {
        Console.Write("X: ");
        var coor_x = int.Parse(Console.ReadLine());

        Console.Write("Y: ");
        var coor_y = int.Parse(Console.ReadLine());
        

        var quadrante = (coor_y, coor_x) switch
        {
          (> 0, > 0) => "Primeiro",
          (> 0, < 0) => "Segundo",
          (< 0 ,< 0) => "Terceiro",
          (< 0 ,> 0) => "Quarto",
          _ => null
        };
        if (quadrante == null)
        {
          break;
        }
        
        Console.WriteLine(quadrante);
      }
    }
  }
}