using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestCommonDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates the greatest common divisor (GCD) of given two numbers. 
            //Use the Euclidean algorithm (find it in Internet).

            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K: ");
            int k = int.Parse(Console.ReadLine());

            for (int i = 1; i < n/2; i++)
            {
                if (n%i == 0 && k%i ==0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
