using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Excercies6
    {
        static void Main(string[] args)
        {
            //Write a program that enters the coefficients a, b and c of a
            //quadratic equation
            //a* x2 +b * x + c = 0
            //and calculates and prints its real roots.Note that quadratic
            //equations may have 0, 1 or 2 real roots.  

            Console.WriteLine("Let's find the roots in a*x2 + b*x + c =0.\n" +
                "Enter the coefficents a, b, and c: ");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            double x1;
            double x2;
            double D;

            D = b * b - 4 * a * c;

            if(D < 0)
            {
                Console.WriteLine("There isn't a real roots!");
            }

            if (D == 0)
            {
                x1 = -b / (2 * a);
                Console.WriteLine($"There is only one real root.\nThe root is {x1}");
            }

            if (D > 0)
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);

                Console.WriteLine($"There is two real roots.\nFirst root is {x1}\nSecond root is {x2}");
            }


        }
    }
}
