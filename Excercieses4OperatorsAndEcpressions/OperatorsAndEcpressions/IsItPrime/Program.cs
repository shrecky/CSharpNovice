using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write an expression that checks if given positive integer
            //number n(n ≤ 100) is prime.E.g. 37 is prime.

            Console.Write("Enter a integer between 0 and 100: ");

            int n = int.Parse(Console.ReadLine());

            int[] m = new int[100];
            int a = 0;
            bool isPrime = true;
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100 / 2; j++) //тук оптимизирах цикъла като разделих 100 на 2 защото е безмислено да ходи чак до 100
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    a++;
                    m[a] = i;                    
                }
                isPrime = true;
            }

            for (int i = 0; i < m.Length; i++)
            {
                if (n == m[i])
                {
                    Console.WriteLine(n + " is prime");
                    break;
                }
                else
                {
                    Console.WriteLine(n + " is not prime");
                    break;
                }

            }
           




        }
    }
}
