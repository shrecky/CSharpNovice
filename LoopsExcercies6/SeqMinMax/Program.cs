using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeqMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads from the console a sequence of N integer numbers and returns 
            //the minimal and maximal of them.

            //Console.WriteLine("Enter an integer:");
            //int n = int.Parse(Console.ReadLine());
            //int[] m = new int[n];
            //int a;
            //int b;
            //int z = 0;


            //for (int i = 0; i <= m.Length - 1; i++)
            //{
            //    Console.WriteLine("Enter an integer: ");
            //    a = int.Parse(Console.ReadLine());
            //    m[i] = a;
            //}

            //for (int i = 0; i <= m.Length - 1; i++)
            //{
            //    z = 1;
            //    z++;
            //    if (m[i] < m[z])
            //    {
            //        b = m[i];
            //        m[i] = m[z];
            //        m[z] = b;

            //    }
            //}
            //for (int i = 0; i <= m.Length - 1; i++)
            //{
            //    Console.Write(m[i] + " \n");
            //}

            //Console.WriteLine("Max is " + m[0]);
            //Console.WriteLine("Min is " + m[n-1]);


            int n;
            string[] numbers;
            bool isInteger = true;
            int minimal = int.MaxValue;
            int maximal = int.MinValue;
            Console.Write("Enter a sequence of numbers delimited with \",\":");
            numbers = (Console.ReadLine()).Split(',');
            int[] intNumbers = new int[numbers.Length];

            for (int i = 0; i < (numbers.Length); i++)
            {
                isInteger = int.TryParse(numbers[i], out intNumbers[i]);
                if (isInteger == false)
                {
                    break;
                }
            }
            if (isInteger)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (intNumbers[i] < minimal)
                    {
                        minimal = intNumbers[i];
                    }
                    if (intNumbers[i] > maximal)
                    {
                        maximal = intNumbers[i];
                    }
                }
                Console.WriteLine("minimal={0}", minimal);
                Console.WriteLine("maximal={0}", maximal);
            }
            else
            {
                Console.WriteLine("Not a valid entry! Some of the entries are not integer!");
            }

        }
    }
}
