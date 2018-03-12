using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> array = new List<int>() { 4, 3, 4, 5, -1, -2, -3, 2 };

            Console.WriteLine("Исходный массив: ");

            foreach (int item in array)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.WriteLine();

            DeletingFromArray output = new DeletingFromArray();
            List<DeletingFromArray> deleting = output.ToDeleting(array: array);

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
