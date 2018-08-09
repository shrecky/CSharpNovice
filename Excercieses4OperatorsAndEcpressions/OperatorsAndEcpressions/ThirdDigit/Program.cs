using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that checks for given integer if its third digit
            //(right-to - left) is 7.E.g. 1732 → true.

            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int thirdDigit = (number / 100) % 10; 
            if (thirdDigit == 7)
            {
                Console.WriteLine("The third digits IS seven!");
            }
            else
            {
                Console.WriteLine("The third digit IS NOT seven.");
            }
        }
    }
}
