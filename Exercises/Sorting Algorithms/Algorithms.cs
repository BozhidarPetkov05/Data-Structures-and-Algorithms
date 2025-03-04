using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public static class Algorithms
    {
        public static int[] BubbleSort(int[] arr)
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
            return arr;
        }

        public static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                } 
            }

            return arr;
        }

        public static void MergeSort(int[] arr, int left, int right)
        {
            //When we keep dividing the left becomes equal to right
            if (left >= right)
            {
                return;
            }

            //We find the middle of the array
            int middle = (left + right) / 2;

            //--Recursion--
            //First half
            MergeSort(arr, left, middle);
            //Second half
            MergeSort(arr, middle + 1, right);

            Merge(arr, left, middle, right);
        }

        private static void Merge(int[] arr, int left, int middle, int right)
        {
            //Finding the size of the 2 arrays
            int size1 = middle - left + 1;
            int size2 = right - middle;

            //Creating 2 temporary arrays
            int[] temp1 = new int[size1];
            int[] temp2 = new int[size2];

            //Filling the first array
            for (int i = 0; i < size1; i++)
            {
                temp1[i] = arr[left + i];
            }

            //Filling the second array
            for (int i = 0; i < size2; i++)
            {
                temp2[i] = arr[middle + i + 1]; //starting from the middle element + 1 so they don't copy
            }

            int firstInitial = 0;
            int secondInitial = 0;

            int mergedInitial = left;

            //Loop for filling the merged array
            while (firstInitial < size1 && secondInitial < size2)
            {
                //if the first element is lower we insert it into the merged array and increment the index of the first array
                if (temp1[firstInitial] <= temp2[secondInitial])
                {
                    arr[mergedInitial] = temp1[firstInitial];
                    firstInitial++;
                }
                //If the second element is bigger we do the same as before
                else
                {
                    arr[mergedInitial] = temp2[secondInitial];
                    secondInitial++;
                }
                //We increment the index of the merged array
                mergedInitial++;
            }

            //Filling the array with the remaining elements if there are any
            while (firstInitial < size1)
            {
                arr[mergedInitial] = temp1[firstInitial];
                
                firstInitial++;
                mergedInitial++;
            }

            while (secondInitial < size2)
            {
                arr[mergedInitial] = temp2[secondInitial];

                secondInitial++;
                mergedInitial++;
            }
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

        private static void QuadMerge(int[] arr, int start, int firstMiddle, int secondMiddle, int thirdMiddle, int end)
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

            //while (firstIndex < size1)
            //{
            //    arr[mainIndex] = temp1[firstIndex];
            //    firstIndex++;
            //    mainIndex++;
            //}

            //while (secondIndex < size2) 
            //{
            //    arr[mainIndex] = temp2[secondIndex];
            //    secondIndex++;
            //    mainIndex++;
            //}

            //while (thirdIndex < size3)
            //{
            //    arr[mainIndex] = temp3[thirdIndex];
            //    thirdIndex++;
            //    mainIndex++;
            //}

            //while (fourthIndex < size4)
            //{
            //    arr[mainIndex] = temp4[fourthIndex];
            //    fourthIndex++;
            //    mainIndex++;
            //}
        }
    }
}
