using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSumSqure
{
    class Program
    {     

        static void Main(string[] args)
        {
            int bestRow = 0;
            int bestSum = 0;
            int bestCol = 0;
            Console.Write("Enter matrix height: ");
            int n = int.Parse(Console.ReadLine());            
            Console.Write("Enter matrix length: ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write($"Element {row},{col}: ");
                    matrix[row, col] = int.Parse(Console.ReadLine());                    
                }                    
            }

            Console.WriteLine();

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                    Console.Write("{0,4} ", matrix[row, col]);
                Console.WriteLine("\n");
            }

            for (int row = 0; row < matrix.GetLongLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLongLength(1) - 2; col++)
                {
                    int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                                     matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                                     matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (currentSum > bestSum)
                    {
                        bestSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine("\nBest square with sum {0}: \n", bestSum);
            for (int i = bestRow; i < bestRow + 3; i++)
            {
                for (int j = bestCol; j < bestCol + 3; j++)
                    Console.Write("{0,4}", matrix[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }             

    
}
