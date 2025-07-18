using System.Security.Cryptography;

namespace Desafio17
{
    class Program
    {
        public static void Main(String[] args)
        {
            var alcool = 0;
            var gasolina = 0;
            var diesel = 0;
            
            while (true)
            {
                Console.Write("Qual combustivel");
                var tipo_boost = int.Parse(Console.ReadLine());

                int? menu = tipo_boost switch
                {
                    1 => alcool++,
                    2 => gasolina++,
                    3 => diesel++,
                    4 => null,
                    _ => -1

                };

                if (menu == null) break;
                if (menu == -1) Console.WriteLine("Invalido");
            }
            Console.WriteLine($"\n\nMuito Obrigado!\n\nÁlcool: {alcool}\nGasolina: {gasolina}\nDiesel: {diesel}");
        }
    }
}