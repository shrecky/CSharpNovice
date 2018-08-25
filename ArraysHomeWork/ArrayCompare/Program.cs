using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads two arrays from the console and compares them element by element.

            Console.WriteLine("Enter the length of the first array:");
            int n = int.Parse(Console.ReadLine());
            int[] m1 = new int[n];
            Console.WriteLine("Enter the length of the second array:");
            int a = int.Parse(Console.ReadLine());
            int[] m2 = new int[a];
            int z;
            int x;




            for (int i = 0; i <= m1.Length - 1; i++)
            {
                Console.WriteLine($"Enter an element{i} of first array: ");
                z = int.Parse(Console.ReadLine());
                m1[i] = z;
            }

            Console.WriteLine("The elements of the first array are: ");

            for (int i = 0; i <= m1.Length - 1; i++)
            {
                Console.Write(m1[i] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i <= m2.Length - 1; i++)
            {
                Console.WriteLine($"Enter an element{i} of second array: ");
                x = int.Parse(Console.ReadLine());
                m2[i] = x;
            }

            Console.WriteLine();
            Console.WriteLine("The elements of the second array are: ");
            for (int i = 0; i <= m2.Length - 1; i++)
            {
                Console.Write(m2[i] + " ");
            }

            if (m1.Length > m2.Length)
            {
                Console.WriteLine("\nResult -> The first array has bigger size than the second one.\n");
            }
            else if (m1.Length < m2.Length)
            {
                Console.WriteLine("\nResult -> The second array has bigger size than the first one.\n");
            }
            else
            {
                Array.Sort(m1);
                Array.Sort(m2);

                Console.WriteLine("\nResult: ");
                Console.WriteLine("1) The two arrays have equals sizes.");

                // Compares two arrays element-by-element 
                for (int i = 0; i < m1.Length; i++)
                {
                    if (m1[i] != m2[i])
                    {
                        Console.WriteLine("2) And different elements.\n");
                        return;
                    }
                }

                Console.WriteLine("2) And equal elements.\n");
            }

        }

        
    }
}