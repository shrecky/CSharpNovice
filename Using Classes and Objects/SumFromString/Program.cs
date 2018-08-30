using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a text (containing numbers): ");
            string str = Console.ReadLine();

            string[] tokens = str.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            int sum = 0;

            for (int i = 0; i < tokens.Length; i++)
            {
                int number = 0;
                sum += int.TryParse(tokens[i], out number) ? number : 0;
            }

            Console.WriteLine($"\nSum of numbers: {sum}\n");
        }
    }
}
