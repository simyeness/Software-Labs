using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class DeletingFromArray
    {
        private List<int> array;

        public DeletingFromArray(List<int> array)
        {
            this.array = array;
        }

        public List<int> DeleteToArray(List<int> array)
        {
            List<int> result = new List<int>(array);
            array.RemoveAll(x => x % array[array.Count-1] != 0);
            return result;
        }
    }
}