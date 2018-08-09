using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Excercies3
    {
        static void Main(string[] args)
        {
            //Write a program that finds the biggest of three integers
            //using nested if statements.

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum
                || firstNum > thirdNum
                || secondNum > thirdNum
                || secondNum > firstNum
                || thirdNum > firstNum
                || thirdNum > secondNum)
            {
                if (firstNum > secondNum && firstNum > thirdNum)
                {
                    Console.WriteLine("The greatest num is {0}", firstNum);
                }

                if (secondNum > firstNum && secondNum > thirdNum)
                {
                    Console.WriteLine("The greatest num is {0}", secondNum);
                }

                if (thirdNum > firstNum && thirdNum > secondNum)
                {
                    Console.WriteLine("The greatest num is {0}", thirdNum);
                }
            }

        }
    }
}
