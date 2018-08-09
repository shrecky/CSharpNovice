using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given integer is odd or even.

            Console.WriteLine("Please enter an integer: ");

            int x = Int32.Parse(Console.ReadLine());
                           
                if (x % 2 == 0)
                {
                    Console.WriteLine($"{x} is even");
                }
                else
                {
                    Console.WriteLine($"{x} is odd");
                }

            


        }
    }
}
