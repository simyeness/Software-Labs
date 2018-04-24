/* Удалить столбец, содержащий минимальное отрицательное. */

using System;
using System.Collections.Generic;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            List<List<int>> array = new List<List<int>>();
            Random rand = new Random();
            Console.Write("Исходный массив: \n");

            array.Add(new List<int>() { -10, 5, -1, 8 });
            array.Add(new List<int>() { 3, -21, 12, -7 });
            array.Add(new List<int>() { 7, 9, -2, 0 });
            array.Add(new List<int>() { -3, 8, -15, 4 });

            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array[i].Count; j++)
                {
                    Console.Write(array[i][j] + "  \t");
                }
                Console.WriteLine();
            }

            DeletingColumn del = new DeletingColumn();

            List<List<int>> result = del.ToDeleteCol(array);

            Console.Write("\nИтоговый массив: \n");
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array[i].Count; j++)
                {
                    Console.Write(array[i][j] + "  \t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
