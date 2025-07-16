// See https://aka.ms/new-console-template for more information
using System;

namespace Desafio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor");
            int number =  int.Parse(Console.ReadLine());
            
            Console.WriteLine(isOdd(number));
            
            
        }

        static string isOdd(int number)
        {
           return number % 2 == 0 ? "even" : "odd"; 
        }
    }
}

