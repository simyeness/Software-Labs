using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            {
                YearToCenturyConverter coverter = new YearToCenturyConverter();
                Console.Write("Введите номер года: ");
                string yearString = Console.ReadLine();
                int cent = coverter.ConvertToCentury(yearString);
                Console.WriteLine("Столетие: {0}", cent);
                Console.ReadLine();
            }
        }
    }
}

