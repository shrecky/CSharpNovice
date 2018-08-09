using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Excercies7
    {
        static void Main(string[] args)
        {
            //Write a program that finds the greatest of given 5 variables.

            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            int e = Int32.Parse(Console.ReadLine());

            if (a < b) a = b;
            if (a < c) a = c;
            if (a < d) a = d;
            if (a < e) a = e;

            Console.WriteLine($"{a} is the biggest number.");
        }
    }
}
