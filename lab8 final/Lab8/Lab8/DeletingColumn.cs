using System.Collections.Generic;

namespace Lab8
{
    class DeletingColumn
    {
        private int ToFindElement(List<List<int>> array)
        {
            int indexOfmin = 0;
            int min = array[0][0];
            for (int i = 0; i < array.Count; i++)
            {
                for (int j = 0; j < array.Count; j++)
                {
                    if (array[i][j] < min)
                    {
                        min = array[i][j];
                        indexOfmin = j;
                    }
                }
            }
            return indexOfmin;
        }

        public List<List<int>> ToDeleteCol(List<List<int>> array)
        {
            int j = ToFindElement(array);
            for (int i = 0; i < array.Count; i++)
            {
                array[i].RemoveAt(j);
            }
            return array;
        }
    }
}
