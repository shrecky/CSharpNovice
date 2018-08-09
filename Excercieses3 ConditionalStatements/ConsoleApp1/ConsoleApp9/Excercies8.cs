using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Excercies8
    {
        static void Main(string[] args)
        {
            //Write a program that, depending on the user's choice inputs int,
            //double or string variable. If the variable is integer or double,
            //increases it with 1.If the variable is string, appends "*" at its
            //end.The program must show the value of that variable as a
            //console output. Use switch statement.

            Console.WriteLine("Please enter a choice from int double or string");
            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "int":
                    Console.WriteLine("Please enter an int");
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
