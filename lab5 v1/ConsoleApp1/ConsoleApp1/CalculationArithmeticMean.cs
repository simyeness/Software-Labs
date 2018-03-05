using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
   public class CalculationArithmeticMean
    {
        public List<CalculationArithmeticMean> ArithmeticMean(List<int> array)
        {
            var result = new List<CalculationArithmeticMean>();
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
            double arMean = Convert.ToDouble(sum / number);

            for (int i = 0; i < array.Count; i++)
            {
                if (Math.Abs(array[i]) > arMean)
                {
                    array.Insert(i + 1, 0);
                }
            }
            Console.WriteLine($"Среднее арифметическое: {arMean}");
            return result;
        }
    }
}
