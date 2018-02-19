namespace ConsoleApp1
{
    public class CountingOfRoundBrackets
    {
        public int ToCountOfRoundBrackets(string textString)
        {
            int i = 0, error = 0, number = 0, answer;
            while (i < textString.Length)
            {
                if (textString[i] == '(') number = number + 1;
                if (textString[i] == ')') number = number - 1;
                if (number < 0 && error == 0) error = i;
                i++;
            }
            if (error != 0) answer = error + 1;
            else if (number > 0) answer = -1;
            else answer = 0;

            return answer;
        }
    }
}
