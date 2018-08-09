using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalan
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Console.WriteLine("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            decimal Cn;
            long fac1;
            long fac2;
            long fac3;

            fac1 = n;

            for (int i = n-1; i >= 1; i--)
            {
                fac1 = fac1 * i;
            }
            Console.WriteLine(fac1);

            fac2 = 2*n;

            for (int i = 2*n - 1; i >= 1; i--)
            {
                fac2 = fac2 * i;
            }
            Console.WriteLine(fac2);

            fac3 = n + 1;

            for (int i = n; i >= 1; i--)
            {
                fac3 = fac3 * i;
            }
            Console.WriteLine(fac3);

            Cn = fac2 / (fac1 * fac3);

            Console.WriteLine(Cn);

        }
    }
}
