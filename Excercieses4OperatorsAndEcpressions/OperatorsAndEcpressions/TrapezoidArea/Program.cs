using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that calculates trapezoid's area by
            //given sides a and b and height h.


            Console.WriteLine("Enter side a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter side b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height h: ");
            double h = double.Parse(Console.ReadLine());

            double s = ((a + b) * h) / 2;
            Console.WriteLine($"The area is {s}");


        }
    }
}
