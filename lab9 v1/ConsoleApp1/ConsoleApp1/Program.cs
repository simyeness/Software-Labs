using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Генерируемый начальный массив: ");
            Random rand = new Random();
            int n = 3;
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rand.Next(-10, 10);
                    Console.Write(String.Format("{0,3} ", array[i, j]));
                }
                Console.WriteLine("\t");
            }

            Console.WriteLine();

            Streamlining scrambling = new Streamlining(array);
            int[,] result = scrambling.Replacement(array);
            Console.WriteLine("Массив после перестановки: ");
            for (int i = 0; i < result.GetLength(1); i++)
            {
                for (int j = 0; j < result.GetLength(0); j++)
                {
                    Console.Write(String.Format("{0,3} ", result[i, j]));
                }
                Console.WriteLine("\t");
            }
            Console.ReadLine();
        }
    }
}
