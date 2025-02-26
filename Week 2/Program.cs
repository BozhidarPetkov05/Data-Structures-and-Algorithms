using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
            };

            int[,] matrix2 =
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            Console.WriteLine("Print Matrix: ");
            PrintMatrix(matrix);
            Console.WriteLine();

            Console.WriteLine("Transpose Matrix: ");
            Transpose(matrix2);
            PrintMatrix(matrix2);
            Console.WriteLine();

            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine("Index: " + FindIndexOf(arr, 5));
            Console.WriteLine();

            Console.WriteLine("Binary Searh Index: " + BinarySearch(arr, 7));
            Console.WriteLine();

            Console.WriteLine("Bubble Sort: ");
            int[] bubbleSortArr = { 8, 9, 4, 5, 58, 14, -85 };
            BubbleSort(bubbleSortArr);
            PrintArray(bubbleSortArr);
            Console.WriteLine();

            Console.WriteLine("Direct Selection: ");
            int[] directSelectionArr = { 3, 8, 45, 10, -8, 74, 10 };
            DirectSelection(directSelectionArr);
            PrintArray(directSelectionArr);
            Console.WriteLine();

            Console.WriteLine("Insertion Sort: ");
            int[] insertionSortArr = { 1, 8, 17, 81, 24, 63, 13, -7, 23 };
            InsertionSort(insertionSortArr);
            PrintArray(insertionSortArr);
            Console.WriteLine();
        }

        //Prints an existing array
        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        //Prints an existing matrix
        public static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        //Transposes matrix
        public static void Transpose(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    int temp = matrix[row, col];
                    matrix[row, col] = matrix[col, row];
                    matrix[col, row] = temp;
                }
            }
        }

        //Returns the index of the searched element
        public static int FindIndexOf(int[] arr, int elm)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == elm)
                {
                    return i;
                }
            }
            return -1;
        }

        ////Returns the index of the searched element using binary search
        public static int BinarySearch(int[] arr, int elm)
        {
            int leftBorder = 0;
            int rightBorder = arr.Length - 1;

            while (leftBorder <= rightBorder)
            {
                int middle = (leftBorder + rightBorder) / 2;
                if (arr[middle] == elm)
                {
                    return middle;
                }
                else if (arr[middle] < elm)
                {
                    leftBorder = middle + 1;
                }
                else
                {
                    rightBorder = middle - 1;
                }
            }

            return -1;
        }

        //Sorts an array using bubble sort
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        //Sorts an array using direct selection
        public static void DirectSelection(int[] arr)
        {
            int minIndex = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = int.MaxValue;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        minIndex = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }

        //Sorts an array using insertion sort
        public static void InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int j = i + 1;
                while (j > 0 && arr[j - 1] > arr[j])
                {
                    int temp = arr[j - 1];
                    arr[j - 1] = arr[j];
                    arr[j] = temp;

                    j--;
                }
            }
        }
    }
}
