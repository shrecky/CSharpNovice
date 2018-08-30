using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greating
{
    class Program
    {
        static void Main(string[] args)
        {
            Greatings();

        }
      static void Greatings()
        {
            Console.Write("Enter your name please: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}.");
        }
        
    }
}
