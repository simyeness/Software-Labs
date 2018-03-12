using System.Collections.Generic;

namespace ConsoleApp1
{
    public class DeletingFromArray
    {

        public List<DeletingFromArray> ToDeleting(List<int> array)
        {
            var result = new List<DeletingFromArray>();
            array.RemoveAll(x => x % array[array.Count - 1] != 0);
            return result;
        }
    }
}
