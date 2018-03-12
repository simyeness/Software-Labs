using System;

namespace ConsoleApp1
{
    class ChangeTwoMax
    {
        public int[] ToChoiceTwoMax(int[] array)
        {

            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= max)
                {
                    max = array[i];
                }
            }

            int minDifference = int.MaxValue;
            int firstIndex = -1;
            int secondIndex = -1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int difference = Math.Abs(array[i] + array[j] - max);
                    if (difference < minDifference)
                    {
                        minDifference = difference;
                        firstIndex = i;
                        secondIndex = j;
                    }
                }
            }

            int temp = array[firstIndex];

            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;

            return array;
        }
    }
}
