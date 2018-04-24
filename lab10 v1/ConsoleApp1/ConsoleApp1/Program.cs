using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            string line;
            StreamReader Reader = new StreamReader("...\\Elements.txt");
            List<int> array = new List<int>();
            while ((line = Reader.ReadLine()) != null)
            {
                array.Add(Convert.ToInt32(line));
            }

            DeletingFromArray delete = new DeletingFromArray(array);

            StreamWriter Writer = new StreamWriter("...\\Result.txt");
            foreach (int i in delete.DeleteToArray(array))
            {
                Writer.Write(i + " ");
            }
            Writer.Close();
            
        }
    }
}