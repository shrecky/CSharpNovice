using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductSign
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());
            double thirdNum = double.Parse(Console.ReadLine());

            if (firstNum < 0 && secondNum < 0 && thirdNum >=0 || 
                secondNum <0 && thirdNum <0 && firstNum >=0 || 
                firstNum <0 && thirdNum <0 && secondNum >= 0)
            {
                Console.WriteLine("+");
            }

            if (firstNum >= 0 && secondNum >=0 && thirdNum >= 0)
            {
                Console.WriteLine("+");
            }

            if (firstNum <0 && secondNum >=0 && thirdNum >= 0
                || secondNum <0 && firstNum >= 0 && thirdNum >=0
                || thirdNum <0 && firstNum >= 0 && secondNum >= 0)
            {
                Console.WriteLine("-");
            }

            if(firstNum <0 && secondNum <0 && thirdNum <0)
            {
                Console.WriteLine("-");
            }
        }
    }
}
