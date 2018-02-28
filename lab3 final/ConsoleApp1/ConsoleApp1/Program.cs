using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            ChoiceThreeNumbers choice = new ChoiceThreeNumbers();

            Console.Write("Введите количество элементов в массиве: ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            int[] mass = new int[numbers];

            

            for (int y = 0; y < mass.Length; y++)
            {
                mass[y] = rand.Next(-100, 100);
                Console.WriteLine($"{y+1} элемент = {mass[y]}");
            }

            int[] choiceNumbers = choice.ToChoiceNumbers(mass);

            Console.WriteLine("\nЧисла, при которых произведение максимально:");

            for (int h = 0; h < choiceNumbers.Length; h++)
            {
                Console.Write(choiceNumbers[h]+" ");
            }

            int answerFinal = choiceNumbers[0] * choiceNumbers[1] * choiceNumbers[2];
            Console.WriteLine($"\nПроизведение: {answerFinal}");

            Console.ReadLine();
        }
    }
}