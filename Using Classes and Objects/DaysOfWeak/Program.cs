using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today is {0:d} -> {1}\n", DateTime.Now, DateTime.Now.DayOfWeek);
        }
    }
}
