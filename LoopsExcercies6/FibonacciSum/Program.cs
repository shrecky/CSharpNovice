using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads a number N and calculates the sum of the first N members 
            //of the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …
            //Each member of the Fibonacci sequence(except the first two) is a sum of the previous two members.

            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            long num1 = 0;
            long num2 = 1;
            long sum = 1;
            long count = 0;
            long[] m = new long[n];


            Console.WriteLine(num1);

            while (count < n)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                m[count] = num2;
                Console.Write(num2 + " ");
                count++;
            }
            Console.WriteLine("\nThe sum is: " + m.Sum());
            

        }
    }
}
