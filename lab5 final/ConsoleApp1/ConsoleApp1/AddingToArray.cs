using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
   public class AddingToArray
    {

    private double ArithmeticMean(List<int> array)
        {
            int sum = 0;
            int number = 0;
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    number++;
                }
            }

            double arMean = sum / number;
            return arMean;
        }

        public void AddToArray(List<int> array)
        {

            Console.WriteLine($"Среднее арифметическое: {ArithmeticMean(array)}");

            for (int i = 0; i < array.Count; i++)
            {
                if (Math.Abs(array[i]) > ArithmeticMean(array))
                {
                    array.Insert(i + 1, 0);
                }
            }
        }
    }
}
