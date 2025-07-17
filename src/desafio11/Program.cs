using System;

namespace Desafio11
{
  class Program
  {
    public static void Main(String[] args)
    {
      Console.Write("Digite a ");
      var order = Console.ReadLine().Split(' ');
      Console.Write(checkOrder(int.Parse(order[0]), int.Parse(order[1])));
    }

     private static double checkOrder(int code, int quantity)
    {
      Dictionary<int, Menu> menus = new Dictionary<int, Menu>()
      {
        {1, new Menu { price=4.00, product="dogão" } },
        {2, new Menu { price=4.50, product="x-salada" } },
        {3, new Menu { price=5.00, product="x-bacon" } },
        {4, new Menu { price=2.00, product="torrada" } },
        {5, new Menu { price=1.50, product="refrigerante" } },
      };

      if (menus.TryGetValue(code, out var menu))
      {
        return menu.price * quantity;
      }
      return 0.0;
    }
  }
  class Menu
  {
    public double price { get; set; }
    public string product { get; set; }
  }
}