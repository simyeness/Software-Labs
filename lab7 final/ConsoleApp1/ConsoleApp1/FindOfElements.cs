namespace ConsoleApp1

{
    class FindOfElements
    {

        public int[,] Replacement(int[,] array)
        {

            int negative = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                if (array[array.GetLength(0) - 1, i] < 0)
                {
                    negative = i;
                    break;
                }
            }

            int positive = 0;

            for (int i = array.GetLength(1) - 1; i >= 0; i--)
            {
                if (array[0, i] > 0)
                {
                    positive = i;
                    break;
                }
            }


            int element = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                element = array[i, positive];
                array[i, positive] = array[i, negative];
                array[i, negative] = element;
            }
            return array;
        }
    }
}