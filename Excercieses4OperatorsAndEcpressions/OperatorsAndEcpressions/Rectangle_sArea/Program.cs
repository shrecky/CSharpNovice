using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_sArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that calculates rectangle’s area by given
            //width and height.
            Console.WriteLine("Enter width:");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height:");
            double h = double.Parse(Console.ReadLine());
            double a;
            a = w * h;
            Console.WriteLine($"Area is {a}");
        }
    }
}
