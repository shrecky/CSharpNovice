using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserChoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a choice from int double or string" );
            string userChoice = Console.ReadLine();

            switch(userChoice)
            {
                case "int":
                    Console.WriteLine("Please enter an int" );
                    int userInt = int.Parse(Console.ReadLine());
                    userInt++;
                    Console.WriteLine(userInt);
                    break;
                case "double":
                    Console.WriteLine("Please enter a double");
                    double userDouble = double.Parse(Console.ReadLine());
                    userDouble++;
                    Console.WriteLine(userDouble);
                    break;
                case "string":
                    Console.WriteLine("Please enter a string");
                    string userInput = Console.ReadLine();
                    Console.WriteLine(userInput + "*");
                    break;

            }
        }
    }
}
