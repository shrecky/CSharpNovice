using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividedBy7And5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a boolean expression that checks for given integer if it can
            //be divided(without remainder) by 7 and 5 in the same time.

            for (; ; )
            {
                Console.WriteLine("Please enter an integer: ");

                int x = Int32.Parse(Console.ReadLine());

                if (x % 7 == 0 && x % 5 == 0)
                {
                    Console.WriteLine($"{x} can be divided by 7 and 5 in the same time");
                }
                else
                {
                    Console.WriteLine($"{x} can't be divided by 7 and 5 in the same time");
                }
            }
        }
    }
}
