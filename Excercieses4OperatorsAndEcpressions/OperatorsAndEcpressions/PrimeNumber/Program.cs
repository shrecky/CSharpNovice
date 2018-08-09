using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = new int[100];
            int a = 0;
            bool isPrime = true;
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100/2; j++) //тук оптимизирах цикъла като разделих 100 на 2 защото е безмислено да ходи чак до 100
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
                    Console.WriteLine(m[a]);
                }
                isPrime = true;
            }

            Console.WriteLine(m[2]);
        }
    }
}
