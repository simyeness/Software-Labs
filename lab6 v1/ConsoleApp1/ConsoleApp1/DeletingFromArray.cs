using System.Collections.Generic;

namespace ConsoleApp1
{
    public class DeletingFromArray
    {

        public List<DeletingFromArray> ToDeleting(List<int> array)
        {
            var result = new List<DeletingFromArray>();

            for(int i = 0; i < array.Count - 1; i++)
            {
                    array.RemoveAll(x => x % 2 != 0);
            }

            return result;
        }
    }
}
