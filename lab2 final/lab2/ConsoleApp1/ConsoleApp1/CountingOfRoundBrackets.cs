namespace ConsoleApp1
{
    public class CountingOfRoundBrackets
    {
        public int ToCountOfRoundBrackets(string textString)
        {
            int i = 0;
            int number = 0;
            
            while (i < textString.Length)
            {
                if (textString[i] == '(') number++;
                if (textString[i] == ')') number--;
                if (number < 0)
                {
                    break;
                }

                i++;
            }

            int answer;
            if (i < textString.Length) answer = i + 1;
            else if (number > 0) answer = -1;
            else answer = 0;

            return answer;
        }
    }
}
