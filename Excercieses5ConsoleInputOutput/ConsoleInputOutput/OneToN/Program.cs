﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneToN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that reads an integer number n from the console
            //and prints all the numbers in the interval[1..n], each on a single
            //line.

            Console.WriteLine("Enter an integer: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }

        }
    }
}
