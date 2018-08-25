using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number N (size of array): ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Enter a searched number: ");
            int searchedNumber = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine($"\nEnter a {n} number(s) to array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"   {i}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            //Array.Sort(numbers);

            int index = BinarySearch(numbers, searchedNumber, 0, numbers.Length);

            if (index != -1) Console.WriteLine($"\nNumber {searchedNumber} found at index: {index}\n");
            else Console.WriteLine($"\nNumber {searchedNumber} not found!\n");
        }

        // Searches for the specified object and returns the index of the first
        // occurrence within the range of elements in the one-dimensional System.Array
        // that starts at the specified index and contains the specified number of elements.
        static int BinarySearch(int[] numbers, int value, int startIndex, int endIndex)
        {
            if (!numbers.Contains(value)) return -1; // Not found

            int middleIndex = (startIndex + endIndex) / 2;

            if (numbers[middleIndex] == value)
            {
                return middleIndex;
            }
            else if (numbers[middleIndex] > value)
            {
                return BinarySearch(numbers, value, 0, middleIndex - 1);
            }
            else
            {
                return BinarySearch(numbers, value, middleIndex + 1, numbers.Length - 1);
            }
        }
    }
}
