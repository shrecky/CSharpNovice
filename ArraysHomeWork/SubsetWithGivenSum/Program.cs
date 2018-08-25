using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsetWithGivenSum
{
    class Program
    {
        static bool isFoundSubset = false;

        static void Main()
        {
            Console.Write("Enter a number N (size of array): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter a searched Sum: ");
            int sum = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine("\nEnter a {0} number(s) to array: ", n);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("   {0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            PrintAllSubsetsWithGivenSum(numbers, sum);

            //TestRunner(); // <- TEST METHOD
        }

        // Find and print all subsets using BITWISE REPRESENTATION
        static void PrintAllSubsetsWithGivenSum(int[] numbers, int searchedSum)
        {
            Console.WriteLine("\nAll subsets with sum = {0}", searchedSum);

            int subsetsCount = (int)(Math.Pow(2, numbers.Length) - 1); // Number of subsets
            List<int> subset = new List<int>();

            for (int i = 1; i <= subsetsCount; i++)
            {
                subset.Clear();

                for (int j = 0; j < numbers.Length; j++)
                    if (((i >> j) & 1) == 1)
                        subset.Add(numbers[j]);

                if (subset.Sum() == searchedSum)
                {
                    isFoundSubset = true;
                    Console.WriteLine(string.Join(" ", subset)); // Print subset
                }
            }

            Console.WriteLine(!isFoundSubset ? "- There are no subsets with Sum " + searchedSum + "\n" : "");
        }

        static void TestRunner()
        {
            Console.WriteLine(new string('-', 40) + "\n");

            int[] test0 = new int[] { 2, 1, 2, 4, 3, 5, 2, 6 };
            Console.WriteLine("Array's elements: {0}", string.Join(" ", test0));
            PrintAllSubsetsWithGivenSum(test0, searchedSum: 14);

            Console.WriteLine(new string('-', 40) + "\n");

            int[] test1 = new int[] { 6, 4, -1, 2, -4, -5, -7, 1, 2, 3 };
            Console.WriteLine("Array's elements: {0}", string.Join(" ", test1));
            PrintAllSubsetsWithGivenSum(test1, searchedSum: 6);

            Console.WriteLine(new string('-', 40) + "\n");
        }
    }
}
