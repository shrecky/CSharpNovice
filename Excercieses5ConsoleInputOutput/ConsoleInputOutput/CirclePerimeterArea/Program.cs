using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirclePerimeterArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads the radius r of a circle and
            //prints its perimeter and area.

            Console.WriteLine("Enter radius:");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * radius * Math.PI;
            Console.WriteLine($"The perimeter is {perimeter}");
            double area = radius * radius * Math.PI;
            Console.WriteLine($"The area is {area}");


        }
    }
}
