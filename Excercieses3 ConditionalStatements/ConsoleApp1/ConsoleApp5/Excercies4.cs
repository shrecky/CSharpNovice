using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Excercies4
    {
        static void Main(string[] args)
        {
            //Sort 3 real values in descending order using nested if
            //statements.

            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            double extraNum;

            if (secondNum > firstNum && secondNum > thirdNum)
            {
                extraNum = firstNum;
                firstNum = secondNum;
                secondNum = extraNum;

                if (thirdNum > secondNum)
                {
                    extraNum = secondNum;
                    secondNum = thirdNum;
                    thirdNum = extraNum;
                }
            }

            if (thirdNum > firstNum && thirdNum > secondNum)
            {
                extraNum = firstNum;
                firstNum = thirdNum;
                thirdNum = extraNum;
                if (thirdNum > secondNum)
                {
                    extraNum = secondNum;
                    secondNum = thirdNum;
                    thirdNum = extraNum;
                }
            }

            if (thirdNum > secondNum)
            {
                extraNum = secondNum;
                secondNum = thirdNum;
                thirdNum = extraNum;
            }



            Console.WriteLine($"The numbers after if  are {firstNum} \t {secondNum} \t {thirdNum}");



        }
    }
}
