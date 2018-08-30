using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10RandomNumbers
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Prints random numbers in interval [100; 200]: ");

            for (int i = 0; i < 10; i++)
                Console.WriteLine(rnd.Next(100, 201));
        }
    }
}
