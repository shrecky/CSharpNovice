using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInputOutput
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads 3 integer numbers from the
            //console and prints their sum.

            Console.WriteLine("Enter number1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number2:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number3:");
            int c = int.Parse(Console.ReadLine());
            int sum = a + b + c;
            Console.WriteLine($"The sum is {sum}");

        }
    }
}
