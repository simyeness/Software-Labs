using System.Linq;

namespace ConsoleApp1
{
    public class ChoiceThreeNumbers
    {
        public int[] ToChoiceNumbers(int[] array)
        {

            int n1 = array[0]; int n2 = array[1]; int n3 = array[2];
            if(array.Count(e => e > 0) >= 3)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (n1 < array[i])
                    {
                        n3 = n2;
                        n2 = n1;
                        n1 = array[i];
                    }
                }
            }
            

            int negativeMax1 = array[0];
            int negativeMax2 = array[1];

            if (array.Count(e=> e < 0) >= 2)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (n1 > array[i])
                    {
                        negativeMax2 = negativeMax1;
                        negativeMax1 = array[i];
                    }
                }
            }

            int[] answer = new int[3];
            if (n1 * n2 * n3 > n1 * negativeMax1 * negativeMax2)
            {
                answer[0] = n1;
                answer[1] = n2;
                answer[2] = n3;
            }
            else
            {
                answer[0] = n1;
                answer[1] = negativeMax1;
                answer[2] = negativeMax2;
            }

            return answer;
        }
    }
}
