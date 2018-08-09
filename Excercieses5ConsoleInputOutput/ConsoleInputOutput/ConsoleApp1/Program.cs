using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //A company has name, address, phone number, fax
            //number, web site and manager. The manager has first
            //name, last name, age and a phone number. Write a
            //program that reads the information about a company
            //and its manager and prints them on the console.

            Console.WriteLine("Enter company name:");
            string companyName = Console.ReadLine();
            Console.WriteLine($"Company name is {companyName}");
        }
    }
}
