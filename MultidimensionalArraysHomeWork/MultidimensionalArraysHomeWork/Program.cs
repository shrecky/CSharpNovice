using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultidimensionalArraysHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            for(; ;)
            {

           
            Console.Write("Enter wich matrix you want a, b, c, d or press 0 to exit: ");
            char swither = char.Parse(Console.ReadLine());
            Console.WriteLine();
            if (swither >= 'a' && swither <= 'd')
            {
                switch (swither)
                {
                    case 'a':
                        MatrixA();
                        break;
                    case 'b':
                        MatrixB();
                        break;
                    case 'c':
                        MatrixC();
                        break;
                    case 'd':
                        MatrixD();
                        break;
                }
            }
                else if (swither == '0')
                {
                    break;
                }
            else
            {
                Console.WriteLine("You entered invalid variant.");
            }
            }
        }

        static void MatrixA()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0, count = 1; row < n; row++)
                for (int col = 0; col < n; col++)
                    matrix[col, row] = count++;

            // Prints matrix
            Console.WriteLine();

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                    Console.Write("{0,4} ", matrix[row, col]);
                Console.WriteLine("\n");
            }
        }

        static void MatrixB()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];
            bool isDirsDown = true;

            for (int col = 0, row = 0, count = 1; col < n; col++)
            {
                while (row >= 0 && row < n)
                {
                    matrix[row, col] = count++;
                    row += isDirsDown ? +1 : -1; // Change 'row' value
                }

                // Change direction and change 'row' value
                row += (isDirsDown = !isDirsDown) ? +1 : -1;
            }

            // Prints matrix
            Console.WriteLine();
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                    Console.Write("{0,4} ", matrix[row, col]);
                Console.WriteLine("\n");
            }
        }

        static void MatrixC()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            var matrix = new int[n, n];

            for (int row = n - 1, count = 1; count <= n * n; row--)
                for (int col = (row >= 0 ? 0 : -row), _row = (row >= 0 ? row : 0); col < (n - (row >= 0 ? row : 0));)
                    matrix[_row++, col++] = count++;

            PrintMatrix(matrix);
        }

        static void PrintMatrix(int[,] matrix)
        {
            Console.WriteLine();

            for (int row = 0; row < matrix.GetLongLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLongLength(1); col++)
                    Console.Write("{0,4} ", matrix[row, col]);

                Console.WriteLine("\n");
            }
        }

        static int[,] matrix;

        static void MatrixD()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            matrix = new int[n, n];
            string direction = "down";
            int row = -1, col = 0;

            for (int count = 1; count <= n * n; count++)
            {
                if (direction == "down")
                {
                    if (matrix[++row, col] == 0) matrix[row, col] = count;
                    if (!IsTraversable(row + 1, col)) direction = "right";
                }
                else if (direction == "right")
                {
                    if (matrix[row, ++col] == 0) matrix[row, col] = count;
                    if (!IsTraversable(row, col + 1)) direction = "up";
                }
                else if (direction == "up")
                {
                    if (matrix[--row, col] == 0) matrix[row, col] = count;
                    if (!IsTraversable(row - 1, col)) direction = "left";
                }
                else if (direction == "left")
                {
                    if (matrix[row, --col] == 0) matrix[row, col] = count;
                    if (!IsTraversable(row, col - 1)) direction = "down";
                }
            }

            // Prints matrix
            Console.WriteLine();
            for (row = 0; row < n; row++)
            {
                for (col = 0; col < n; col++)
                    Console.Write("{0,4} ", matrix[row, col]);
                Console.WriteLine("\n");
            }
        }

        static bool IsTraversable(int row, int col)
        {
            return row >= 0 && row < matrix.GetLongLength(0) &&
                   col >= 0 && col < matrix.GetLongLength(1) && matrix[row, col] == 0;
        }
    }
}
