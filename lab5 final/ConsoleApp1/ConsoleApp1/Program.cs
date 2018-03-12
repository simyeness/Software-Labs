using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
   public class Program
    {
       public static void Main(string[] args)
        {
            List<int> array = new List<int>() { 4, 5, 6, -4, -5, -12, -34, 3, 4 };

            Console.WriteLine("Исходный массив: ");

            foreach (int item in array)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine();
            Console.WriteLine();

            AddingToArray output = new AddingToArray();
            output.AddToArray(array);

            Console.WriteLine();
            Console.WriteLine("Результат: ");
            foreach (int item in array)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
