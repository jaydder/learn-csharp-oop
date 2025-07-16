using System;
using System.Globalization;
namespace Desafio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee, workHours;
            double valueHour;

            employee = 6;
            workHours = 145;
            valueHour = 15.55;

            double difference = salary(workHours, valueHour);

            Console.WriteLine("Employe: "+ employee);
            Console.WriteLine("Salary: "+ difference);
        }

        static double salary(int workHours, double valueHour)
        {
            return Math.Round(workHours * valueHour, 2);
        }
    } 
}