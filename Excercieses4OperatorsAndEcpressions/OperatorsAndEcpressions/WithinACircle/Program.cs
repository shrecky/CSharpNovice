using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithinACircle
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given point(x, y) is within a
            //circle K(O, 5).

            Console.WriteLine("Please enter the coordinates X & Y coordinates:");

            Console.Write("X: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Y: ");
            double y = double.Parse(Console.ReadLine());
            Console.Write("Circle radius: "); 
            double circleRadius = double.Parse(Console.ReadLine()); ;

            if ((x * x + y * y) <= (circleRadius * circleRadius))
            {
                Console.WriteLine($"The given point IS within a circle with radius if {circleRadius}!");
            }
            else
            {
                Console.WriteLine($"The given point IS NOT within a circle with radius if {circleRadius}!");
            }
        }
    }
    }

