using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to calculate the sum (with accuracy of 0.001): 1
            //+1 / 2 - 1 / 3 + 1 / 4 - 1 / 5 + ...

            Console.Write("Enter last number: ");
            int length = Int32.Parse(Console.ReadLine());
            double sum = 1.0;

            for (int i = 2; i <= length; i++)
            {
                sum += (1.0 / i);
            }

            Console.WriteLine($"{sum:F3}");

        }
    }
}
