namespace Desafio15
{
  class Program
  {
    public static void Main(String[] args)
    {

      while (true)
      {
        Console.WriteLine("Digite a senha");
        int pwd = int.Parse(Console.ReadLine());
        
        if (pwd == 2002)
        {
          Console.WriteLine("Senha valida");
          break;
        }
        else
        {
          Console.WriteLine("Senha invalida");
        }
      }
    }

  }
}

