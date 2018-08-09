using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherFac
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).
            Console.WriteLine("Enter N: ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter K: ");
            int K = int.Parse(Console.ReadLine());
            double result;
            int a = K - N;
            int fact1;
            int fact2;
            int fact3;

            if (K > N)
            {
                fact1 = N;
                for (int i = N - 1; i >= 1; i--)
                {
                    fact1 = fact1 * i;
                }
                Console.WriteLine("N! is " + fact1);
                fact2 = K;
                for (int i = K - 1; i >= 1; i--)
                {
                    fact2 = fact2 * i;
                }
                Console.WriteLine("K! is " + fact2);
                fact3 = a;
                for (int i = a - 1; i >= 1; i--)
                {
                    fact3 = fact3 * i;
                }

                result = (fact1*fact2)/fact3;
                Console.WriteLine("N!*K!/(K-N)! is " + result);
            }

            else
            {
                Console.WriteLine("Something went wrong!");
            }

        }
    }
}
