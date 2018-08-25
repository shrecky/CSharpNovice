using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number N (size of array): ");
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];
            Console.WriteLine($"\nEnter a {n} number(s) to array: ");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"   {i+1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Adds numbers to dictionary
            Dictionary<int, int> frequents = new Dictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (!frequents.ContainsKey(numbers[i])) frequents.Add(numbers[i], 1);
                else frequents[numbers[i]]++;
            }

            // Get the key of the highest value
            var max = frequents.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            // Print all array elements
            Console.WriteLine($"\nArray's elements: {string.Join(" ", numbers)}" );

            // Print all keys (numbers) with the highest value
            Console.WriteLine("\nMost frequent numbers: ");
            foreach (KeyValuePair<int, int> item in frequents)
                if (item.Value == frequents[max])
                    Console.WriteLine($"{item.Key} -> {frequents[item.Key]} times");

            Console.WriteLine();
        }
    }
}
