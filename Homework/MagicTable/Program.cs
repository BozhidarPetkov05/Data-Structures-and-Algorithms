using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1 - 20): ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1)
            {
                n = 1;
            }
            else if (n > 20)
            {
                n = 20;
            }

            int[,] table = new int[n, n];
            TableFiller(table);
            PrintTable(table);
            IsMagicSquare(table);
        }

        static void TableFiller(int[,] table)
        {
            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    Console.Write($"Enter number on row {row} col {col}: ");
                    table[row, col] = int.Parse(Console.ReadLine());
                }
            }
        }

        static void PrintTable(int[,] table)
        {
            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    Console.Write(table[row,col] + " ");
                }
                Console.WriteLine();
            }
        }

        static void IsMagicSquare(int[,] table)
        {
            int size = table.GetLength(0);
            
            int[] rowSums = new int[size];
            int[] colSums = new int[size];
            
            int firstDiagonalSum = 0;
            int secondDiagonalSum = 0;

            for (int row = 0; row < size; row++)
            {
                int currentRowSum = 0;
                for (int col = 0; col < size; col++)
                {
                    currentRowSum += table[row, col];
                }
                rowSums[row] = currentRowSum;
            }

            for (int col = 0; col < size; col++)
            {
                int currentColSum = 0;
                for (int row = 0; row < size; row++)
                {
                    currentColSum += table[row, col];
                }
                colSums[col] = currentColSum;
            }

            for (int firstDiagonal = 0; firstDiagonal < size; firstDiagonal++)
            {
                firstDiagonalSum += table[firstDiagonal, firstDiagonal];
            }

            for (int secondDiagonal = 0; secondDiagonal < size; secondDiagonal++)
            {
                secondDiagonalSum += table[secondDiagonal, size - secondDiagonal - 1];
            }

            bool areEqual = true;

            for (int i = 0; i < size - 1; i++)
            {
                if (rowSums[i] != rowSums[i + 1])
                {
                    areEqual = false;
                    break;
                }
            }

            if (areEqual)
            {
                for (int i = 0; i < size - 1; i++)
                {
                    if (colSums[i] != colSums[i + 1])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }

            if (areEqual)
            {
                if (firstDiagonalSum != secondDiagonalSum)
                {
                    areEqual = false;
                }
            }

            if (areEqual)
            {
                Console.WriteLine($"The table is magic square with sum: {rowSums[0]}");
            }
            else
            {
                Console.WriteLine("The table is not magic square.");
            }
        }
    }
}
