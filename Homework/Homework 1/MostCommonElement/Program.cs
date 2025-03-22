using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostCommonElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            RandomFiller(arr);
            MostCommon(arr);
        }

        static void RandomFiller(int[] arr)
        {
            Random randomNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randomNum.Next(9, 100);
            }
        }

        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        static void MostCommon(int[] arr)
        {
            int mostCommonElement = arr[0];
            int mostCommonCnt = 1;
            int currentCnt = 1;

            BubbleSort(arr);
            PrintArray(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currentElm = arr[i];
                int nextElm = arr[i + 1];

                if (currentElm == nextElm)
                {
                    currentCnt++;
                }
                else
                {
                    if (currentCnt > mostCommonCnt)
                    {
                        mostCommonCnt = currentCnt;
                        mostCommonElement = arr[i];
                    }
                    currentCnt = 1;
                }
            }

            Console.WriteLine($"Most common {mostCommonElement} occurred {mostCommonCnt} times");
        }

        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swapped = true;
                    }
                }
                if (swapped == false)
                {
                    break;
                }
            }
        }
    }
}
