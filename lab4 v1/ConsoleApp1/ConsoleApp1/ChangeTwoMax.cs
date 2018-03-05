namespace ConsoleApp1
{
    class ChangeTwoMax
    {
        public int[] ToChoiceTwoMax(int[] array)
        {

            int max1 = 0;
            int max2 = 0;
            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= max1)
                {
                    max1 = array[i];
                    index1 = i;
                }

                else if (array[i] >= max2)
                {
                    max2 = array[i];
                    index2 = i;
                }
            }
            int temp = array[index1];

            array[index1] = array[index2];
            array[index2] = temp;

            return array;
        }
    }
}
