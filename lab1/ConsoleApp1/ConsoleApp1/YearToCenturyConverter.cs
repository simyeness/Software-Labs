using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class YearToCenturyConverter
    {
        public int ConvertToCentury(string yearString)
        {
            int yearInt = Convert.ToInt32(yearString);
            int century = (yearInt - 1) / 100 + 1;
            return century;
        }
    }
}
