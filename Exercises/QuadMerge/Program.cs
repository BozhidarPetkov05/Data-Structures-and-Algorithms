using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadMerge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 8, 6, 2 }; //3 elementa
            //int[] arr = { 8, 6, 2, 1}; //4 elementa
            //int[] arr = { 8, 5, 4, 2, 1}; //5 elementa
            //int[] arr = { 8, 1, 2, 3, 14, 8, 19, 2, 82, 45 }; //10 elementa
            int[] arr = { 45, 1, 2, 3, 4, 5, 7, 8, 10, 115, 84, 17, 74, 66, 13, 58}; //16 elementa
            //int[] arr = ArrayFiller(); //proizvolni 10000 elementa
            QuadMergeSort(arr, 0, arr.Length - 1);
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

            int[] arr = new int[10000];
            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(Min, Max);
            }

            return arr;
        }

        public static void QuadMergeSort(int[] arr, int start, int end)
        {
            if (start >= end)
            {
                return;
            }

            int firstMiddle = start + (end - start) / 4;
            int secondMiddle = start + (end - start) / 2;
            int thirdMiddle = start + 3 * (end - start) / 4;

            QuadMergeSort(arr, start, firstMiddle);
            QuadMergeSort(arr, firstMiddle + 1, secondMiddle);
            QuadMergeSort(arr, secondMiddle + 1, thirdMiddle);
            QuadMergeSort(arr, thirdMiddle + 1, end);

            QuadMerge(arr, start, firstMiddle, secondMiddle, thirdMiddle, end);

        }

        public static void QuadMerge(int[] arr, int start, int firstMiddle, int secondMiddle, int thirdMiddle, int end)
        {
            int size1 = firstMiddle - start + 1;
            int size2 = secondMiddle - firstMiddle;
            int size3 = thirdMiddle - secondMiddle;
            int size4 = end - thirdMiddle;

            int[] temp1 = new int[size1];
            int[] temp2 = new int[size2];
            int[] temp3 = new int[size3];
            int[] temp4 = new int[size4];

            for (int i = 0; i < size1; i++)
            {
                temp1[i] = arr[start + i];
            }
            for (int i = 0; i < size2; i++)
            {
                temp2[i] = arr[firstMiddle + i + 1];
            }
            for (int i = 0; i < size3; i++)
            {
                temp3[i] = arr[secondMiddle + i + 1];
            }
            for (int i = 0; i < size4; i++)
            {
                temp4[i] = arr[thirdMiddle + i + 1];
            }

            int firstIndex = 0;
            int secondIndex = 0;
            int thirdIndex = 0;
            int fourthIndex = 0;

            int mainIndex = start;

            while (firstIndex < size1 || secondIndex < size2 || thirdIndex < size3 || fourthIndex < size4)
            {
                int smallest = int.MaxValue;
                int arrayNum = -1;

                if (firstIndex < size1 && temp1[firstIndex] < smallest)
                {
                    smallest = temp1[firstIndex];
                    arrayNum = 1;
                }
                if (secondIndex < size2 && temp2[secondIndex] < smallest)
                {
                    smallest = temp2[secondIndex];
                    arrayNum = 2;
                }
                if (thirdIndex < size3 && temp3[thirdIndex] < smallest)
                {
                    smallest = temp3[thirdIndex];
                    arrayNum = 3;
                }
                if (fourthIndex < size4 && temp4[fourthIndex] < smallest)
                {
                    smallest = temp4[fourthIndex];
                    arrayNum = 4;
                }

                switch (arrayNum)
                {
                    case 1:
                        firstIndex++;
                        break;
                    case 2:
                        secondIndex++;
                        break;
                    case 3:
                        thirdIndex++;
                        break;
                    case 4:
                        fourthIndex++;
                        break;
                    default:
                        break;
                }

                arr[mainIndex] = smallest;

                mainIndex++;
            }
        }
    }
}