namespace ConsoleApp1

{
    class FindOfElements
    {
        private int[,] array;

        public FindOfElements(int[,] array)
        {
            this.array = array;
        }

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

                //if((array[array.GetLength(0) - 1, i] > 0) && negative > array[array.GetLength(0) - 1, i])
                //{
                //    negative = i;

                //}
            }

            int positive = 0;

            for (int i = array.GetLength(1) - 1; i >= 0; i--)
            {
                if (array[0, i] > 0)
                {
                    positive = i;
                    break;
                }

                //if((array[0, i] < 0) && positive < array[0, i])
                //{
                //    positive = i;
                //}
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