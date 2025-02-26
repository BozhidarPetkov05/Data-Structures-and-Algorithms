using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine();

            int someVar = 5;

            int[] arr = new int[5];
            int[] arr2 = { 4, 5, 7, 8, 9 };
            arr[0] = 495;

            Console.WriteLine("Print Array: ");
            PrintArray(arr2);
            Console.WriteLine();

            Console.WriteLine("Min Value: " + FindMin(arr2));
            Console.WriteLine("Max Value: " + FindMax(arr2));
            Console.WriteLine();

            Console.WriteLine("Average: " + FindAverage(arr2));
            Console.WriteLine();

            Console.WriteLine("Closest to Average: " + ClosestToAverage(arr2));
            Console.WriteLine();

            Console.WriteLine("Add Element: ");
            int[] newArr = AddElement(arr2, 2, 52);
            PrintArray(newArr);
            Console.WriteLine();

            Console.WriteLine("Remove Element: ");
            newArr = RemoveElement(newArr, 2);
            PrintArray(newArr);
            Console.WriteLine();

            int[] firstArr = { 1, 3, 4, 6, 8 };
            int[] secondArr = { 2, 5, 7 };
            Console.WriteLine("Merge Array: ");
            int[] merged = MergeArray(firstArr, secondArr);
            PrintArray(merged);
            Console.WriteLine();

            Console.WriteLine("Prime Numbers: ");
            PrintPrimes(40);
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

        //Finds the min value in given array
        public static int FindMin(int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }

            return min;
        }

        //Finds the max value in given array
        public static int FindMax(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }

        //Finds the average value in given array
        public static double FindAverage(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            return (double)sum / arr.Length;
        }

        //Finds the value closest to average
        public static int ClosestToAverage(int[] arr)
        {
            double avg = FindAverage(arr);
            double diff = double.MaxValue;
            int closest = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                double expression = Math.Abs(arr[i] - avg);
                if (expression < diff)
                {
                    diff = expression;
                    closest = arr[i];
                }
            }

            return closest;
        }

        //Adds new element to array
        public static int[] AddElement(int[] arr, int index, int value)
        {
            int newCount = arr.Length + 1;
            int[] newArr = new int[newCount];
            bool isAdded = false;

            for (int i = 0; i < newCount; i++)
            {
                if (index == i)
                {
                    newArr[i] = value;
                    isAdded = true;
                }
                else
                {
                    if (isAdded)
                    {
                        newArr[i] = arr[i - 1];
                    }
                    else
                    {
                        newArr[i] = arr[i];
                    }
                }
            }

            return newArr;
        }

        //Removes element from array
        public static int[] RemoveElement(int[] arr, int index)
        {
            int newCount = arr.Length - 1;
            int[] newArr = new int[newCount];

            for (int i = 0; i < newCount; i++)
            {
                if (i < index)
                {
                    newArr[i] = arr[i];
                }
                else
                {
                    newArr[i] = arr[i + 1];
                }
            }

            return newArr;
        }

        //Merges two arrays 
        public static int[] MergeArray(int[] arr1, int[] arr2)
        {
            int totalCount = arr1.Length + arr2.Length;
            int[] newArr = new int[totalCount];

            int arr1tracker = 0;
            int arr2tracker = 0;

            for (int i = 0; i < totalCount; i++)
            {
                if (i == totalCount - 1)
                {
                    int bigger = (arr1[arr1tracker] > arr2[arr2tracker]) ? arr1[arr1tracker] : arr2[arr2tracker];
                    newArr[i] = bigger;
                    break;
                }

                if (arr1[arr1tracker] < arr2[arr2tracker])
                {
                    newArr[i] = arr1[arr1tracker];
                    if (arr1tracker < arr1.Length - 1)
                    {
                        arr1tracker++;
                    }
                }
                else
                {
                    newArr[i] = arr2[arr2tracker];
                    if (arr2tracker < arr2.Length - 1)
                    {
                        arr2tracker++;
                    }
                }
            }

            return newArr;
        }

        //Prints prime numbers
        public static void PrintPrimes(int n)
        {
            bool[] arr = new bool[n + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = true;
            }

            for (int i = 2; i < n; i++)
            {
                if (arr[i])
                {
                    for (int j = i * 2; j < arr.Length; j += i)
                    {
                        arr[j] = false;
                    }
                }
            }

            for (int i = 2; i < n; i++)
            {
                if (arr[i])
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
