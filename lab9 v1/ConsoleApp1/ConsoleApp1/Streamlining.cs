namespace ConsoleApp1
{
    class Streamlining
    {
        private int[,] array;
        public Streamlining(int[,] array)
        {
            this.array = array;
        }

        public int[,] Replacement(int[,] array)
        {
            int element = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int x = 0; x < array.GetLength(0); x++)
                    {
                        for (int y = 0; y < array.GetLength(1); y++)
                        {
                            if (array[i, j] > array[x, y])
                            {
                                element = array[i, j];
                                array[i, j] = array[x, y];
                                array[x, y] = element;
                            }
                        }
                    }
                }
            }

            return array;
        }
    }
}
