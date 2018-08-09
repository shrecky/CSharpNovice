using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            if (firstNum > secondNum || firstNum > thirdNum)
            {
                if (secondNum > firstNum && secondNum > thirdNum)
                {
                    Console.WriteLine("The greatest num is {0}", firstNum);

                }
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
