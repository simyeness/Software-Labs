using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Введите размер массива:");
            int number = int.Parse(Console.ReadLine());

            int[] array = new int[number]; 

            Random rand = new Random();

            for (int j = 0; j < array.Length; j++)
            {
                array[j] = rand.Next(0, 50);
            }

            Console.WriteLine("Вывод исходного массива:");
            foreach (int item in array)
            {
                Console.Write(item.ToString() + " ");  
            }
            Console.WriteLine();
            Console.WriteLine();

            ChangeTwoMax change = new ChangeTwoMax();

            int[] twoMax = change.ToChoiceTwoMax(array);

            Console.WriteLine("Вывод измененного массива:");

            foreach (int item in array)
            {
                Console.Write(item.ToString() + " ");  
            }
            Console.ReadLine();

        }
    }
}