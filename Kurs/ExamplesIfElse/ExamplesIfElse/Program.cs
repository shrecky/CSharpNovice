using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesIfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            int biggestNum = 0;

            if (firstNum>secondNum)
            {
                biggestNum = firstNum;
                firstNum = secondNum;
                secondNum = biggestNum;
            }

            Console.WriteLine("The numbers are {0} and {1}" , firstNum, secondNum);
        }
    }
}
