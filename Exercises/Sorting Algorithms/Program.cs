using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 6, 5, 3, 1, 7, 8, 2, 9, 4, 10 }; //10 elements
            //int[] arr = { 6, 5, 1 }; //3 elements
            //int[] arr = { 3, 5, 6, 1}; //4 elements
            //int[] arr = { 3, 5, 6, 1, 8}; //5 elements
            //int[] arr = { 3, 5, 6, 1, 7, 8, 2, 9, 4, 10, 15, 13, 90, 87,45, 32}; //16 elements
            //int[] arr = { 3, 5, 6, 1, 7, 8, 2, 9, 4, 10, 3, 9, 8 }; //repeating elements
            
            //SortingChecker("Bubble Sort");
            //SortingChecker("Selection Sort");   
            //SortingChecker("Merge Sort");
            //SortingChecker("Quad Merge");
            Algorithms.QuadMergeSort(arr, 0, arr.Length - 1);
            PrintArray(arr);
        }

        public static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        public static int[] ArrayFiller()
        {
            int Min = 0;
            int Max = 10000;

            int[] arr = new int[10000000];
            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(Min, Max);
            }

            return arr;
        }

        public static void TimeCheck(long time)
        {
            Console.WriteLine("Runtime: " + time + "ms");
        }

        public static void SortingChecker(string algorithm)
        {
            switch (algorithm)
            {
                case "Bubble Sort":
                    int[] bubbleSorted = ArrayFiller();
                    Console.WriteLine("Generated Bubble Sort...");

                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    Algorithms.BubbleSort(bubbleSorted);
                    watch.Stop();
                    TimeCheck(watch.ElapsedMilliseconds);
                    watch.Reset();

                    break;

                case "Selection Sort":
                    int[] selectionSorted = ArrayFiller();
                    Console.WriteLine("Generated Selection Sort...");

                    watch = System.Diagnostics.Stopwatch.StartNew();
                    Algorithms.SelectionSort(selectionSorted);
                    watch.Stop();
                    TimeCheck(watch.ElapsedMilliseconds);
                    watch.Reset();
                    break;

                case "Merge Sort":
                    int[] mergeSorted = ArrayFiller();
                    Console.WriteLine("Generated Merge Sort...");

                    watch = System.Diagnostics.Stopwatch.StartNew();
                    Algorithms.MergeSort(mergeSorted, 0, mergeSorted.Length - 1);
                    watch.Stop();
                    TimeCheck(watch.ElapsedMilliseconds);
                    watch.Reset();
                    break;

                case "Quad Merge":
                    int[] quadSorted = ArrayFiller();
                    Console.WriteLine("Generated Quad Sort...");

                    watch = System.Diagnostics.Stopwatch.StartNew();
                    Algorithms.QuadMergeSort(quadSorted, 0, quadSorted.Length - 1);
                    watch.Stop();
                    TimeCheck(watch.ElapsedMilliseconds);
                    watch.Reset();
                    break;

                default:
                    Console.WriteLine("There is no such algorithm!");
                    break;
            }
        }
    }
}
