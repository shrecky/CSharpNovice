using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] primes = new bool[2000]; // new bool[10000000];
            int count = 0; //Just for good looking :)

            // Find all prime numbers to N
            for (int i = 2; i < Math.Sqrt(primes.Length); i++)
            {
                // Skip these which is not prime
                if (primes[i] == false)
                {
                    for (int j = i * i; j < primes.Length; j += i)
                        primes[j] = true;
                }
            }

            // Print all prime numbers to N
            for (int i = 2; i < primes.Length; i++)
                if (!primes[i])
                {
                    count++;
                    Console.Write(i + "\t");
                    if (count == 10)
                    {
                        Console.WriteLine();
                        count = 0;
                    }
                }
        }
    }
}
