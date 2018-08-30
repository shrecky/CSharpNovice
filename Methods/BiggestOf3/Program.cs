using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiggestOf3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nBiggest number: {GetMax(GetMax(a, b), c)}\n");
        }

        static int GetMax(int a, int b)
        {
            return Math.Max(a, b);
        }
    }
}
