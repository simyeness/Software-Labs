using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class DeletingFromArray
    {
       

    

        public List<int> DeleteToArray(List<int> array)
        {
            List<int> result = new List<int>(array);
            array.RemoveAll(x => x % array[array.Count-1] != 0);
            return result;
        }
    }
}