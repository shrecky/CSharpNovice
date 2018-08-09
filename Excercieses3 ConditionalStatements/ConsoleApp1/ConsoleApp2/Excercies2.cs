using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Excercies2
    {
        static void Main(string[] args)
        {
            //Write a program that shows the sign(+or -) of the product
            //of three real numbers without calculating it. Use a sequence
            //of if statements.
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            if (firstNum < 0 && secondNum < 0 && thirdNum >= 0 ||
                secondNum < 0 && thirdNum < 0 && firstNum >= 0 ||
                firstNum < 0 && thirdNum < 0 && secondNum >= 0)
            {
                Console.WriteLine("+");
            }

            if (firstNum >= 0 && secondNum >= 0 && thirdNum >= 0)
            {
                Console.WriteLine("+");
            }

            if (firstNum < 0 && secondNum >= 0 && thirdNum >= 0
                || secondNum < 0 && firstNum >= 0 && thirdNum >= 0
                || thirdNum < 0 && firstNum >= 0 && secondNum >= 0)
            {
                Console.WriteLine("-");
            }

            if (firstNum < 0 && secondNum < 0 && thirdNum < 0)
            {
                Console.WriteLine("-");
            }

        }
    }
}
