using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsAYearLeap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter an year: ");
            DateTime date = DateTime.Parse("1.1." + Console.ReadLine() + "");

            Console.WriteLine("\nYear {0} is leap: {1}\n", date.Year, DateTime.IsLeapYear(date.Year));
        }
    }
}
