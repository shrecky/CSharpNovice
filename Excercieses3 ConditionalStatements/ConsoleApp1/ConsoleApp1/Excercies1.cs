using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionStatements
{
    class Excercies1
    {
        static void Main(string[] args)
        {

            //Write an if statement that examines two integer variables
            //and exchanges their values if the first one is greater than the
            //second one.

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine($"The numbers are {firstNum} and {secondNum}");

            int biggestNum = 0;

            if (firstNum > secondNum)
            {
                biggestNum = firstNum;
                firstNum = secondNum;
                secondNum = biggestNum;
            }

            Console.WriteLine($"The numbers after if  are {firstNum} and {secondNum}");





        }
    }
}
