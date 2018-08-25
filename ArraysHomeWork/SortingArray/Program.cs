using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sorting an array means to arrange its elements in increasing order. 
            //Write a program to sort an array. Use the "selection sort" algorithm: Find the smallest element, 
            //move it at the first position, find the smallest from the rest, move it at the second position, etc.

            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];            
            Console.WriteLine("Enter the elements of the array: ");
            InitializeArray(array);                
            Console.WriteLine("This is not sorted array: ");
            ShowArray(array);
            SelectionSort(array);
            Console.WriteLine("\nThis is sorted array: ");
            ShowArray(array);
        }

        static void InitializeArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Element {i}:");
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void ShowArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
               
            }
        }

        static int[] SelectionSort(int[] numbers)
        {
            int index, swap;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                index = i;

                for (int j = i + 1; j < numbers.Length; j++)
                    if (numbers[j] < numbers[index])
                        index = j;

                swap = numbers[i];
                numbers[i] = numbers[index];
                numbers[index] = swap;
            }

            return numbers;
        }
    }
}
