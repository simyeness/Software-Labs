using System;

namespace ConsoleApp1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CountingOfRoundBrackets counting = new CountingOfRoundBrackets();
            Console.Write("Введите ваш текст с круглыми скобками: ");
            string textString = Console.ReadLine();
            int count = counting.ToCountOfRoundBrackets(textString);
            Console.WriteLine($"Ответ: {count}");
            if (count == 0) Console.WriteLine("Скобки расставлены правильно, каждой открывающей соответствует одна закрывающая");
            if (count == -1) Console.WriteLine("Не хватает закрывающей скобки");
            if (count > 0) Console.WriteLine($"Ответ ({count}) равен номеру позиции, в которой расположена первая ошибочная закрывающая скобка");
            Console.ReadLine();
        }
    }
}
