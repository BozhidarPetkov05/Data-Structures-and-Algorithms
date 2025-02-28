using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Sorting_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortingChecker("asd");
            SortingChecker("Bubble Sort");
            SortingChecker("Selection Sort");   
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

            int[] arr = new int[40000];
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

                default:
                    Console.WriteLine("There is no such algorithm!");
                    break;
            }
        }
    }
}
