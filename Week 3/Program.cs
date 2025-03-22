using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 8;
            Console.WriteLine($"{n}! = {Factorial(n)}");
            Console.WriteLine($"Fibonacci: {n} -> {Fibonacci(n)}");
            Console.WriteLine("GCD Recursice: " + GCDRecursive(30, 12));
            Console.WriteLine("GCD Iterative: " + GCDIterative(30, 12));

            int[] arr = { 9, 3, 1, 0, 7, 2, 8, 4 };
            MergeSort(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static int Factorial(int n)
        {
            if (n <= 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        public static int Fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static int GCDRecursive(int num1, int num2)
        {
            if (num1 % num2 == 0)
            {
                return num2;
            }

            int remainder = num1 % num2;
            return GCDRecursive(num2, remainder);
        }

        public static int GCDIterative(int num1, int num2)
        {
            while (num1 % num2 != 0)
            {
                int temp = num1 % num2;
                num1 = num2;
                num2 = temp;
            }

            return num2;
        }

        public static void QuickSort(int[] arr, int begin, int end)
        {
            if (begin < end)
            {
                int p = Partition(arr, begin, end);

                QuickSort(arr, begin, p - 1);
                QuickSort(arr, p + 1, end);
            }
        }

        public static int Partition(int[] arr, int begin, int end)
        {
            int p = end;
            int k = begin - 1;
            int temp;

            for (int i = begin; i < end; i++)
            {
                if (arr[i] < arr[p])
                {
                    k++;
                    temp = arr[i];
                    arr[i] = arr[k];
                    arr[k] = temp;
                }
            }

            k++;
            temp = arr[p];
            arr[p] = arr[k];
            arr[k] = temp;

            return k;
        }

        public static void MergeSort(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int middle = (start + end) / 2;

                MergeSort(arr, start, middle);
                MergeSort(arr, middle + 1, end);

                Merge(arr, start, middle, end);
            }
        }

        public static void Merge(int[] arr, int start, int middle, int end)
        {
            int size1 = middle - start + 1;
            int size2 = end - middle;
            int[] temp1 = new int[size1];
            int[] temp2 = new int[size2];

            for (int i = 0; i < size1; i++)
            {
                temp1[i] = arr[start + i];
            }
            for (int i = 0; i < size2; i++)
            {
                temp2[i] = arr[middle + i + 1];
            }

            int index1 = 0;
            int index2 = 0;
            int mainIndex = start;

            while (index1 < size1 && index2 < size2)
            {
                if (temp1[index1] <= temp2[index2])
                {
                    arr[mainIndex] = temp1[index1];
                    index1++;
                }
                else
                {
                    arr[mainIndex] = temp2[index2];
                    index2++;
                }
                mainIndex++;
            }

            while (index1 < size1)
            {
                arr[mainIndex] = temp1[index1];
                index1++;
                mainIndex++;
            }

            while (index2 < size2)
            {
                arr[mainIndex] = temp2[index2];
                index2++;
                mainIndex++;
            }
        }
    }
}
