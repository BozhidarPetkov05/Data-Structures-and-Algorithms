using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrep
{
    public static class Sort
    {
        public static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool isSwapped = false;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Swap(arr, j, j + 1);
                        isSwapped = true;
                    }
                }
                if (!isSwapped)
                {
                    return;
                }
            }
        }
        public static void SelectionSort(int[] arr)
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
                if (minIndex != i)
                {
                    Swap(arr, i, minIndex);
                }
            }
        }
        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }
        }
        public static void QuickSort(int[] arr, int lb, int rb)
        {
            int middle = arr[(lb + rb)/2];
            int i = lb;
            int j = rb;

            while (i <= j)
            {
                while (i <= rb && arr[i] < middle)
                {
                    i++;
                }
                while (j >= lb && arr[j] > middle)
                {
                    j--;
                }

                if (i <= j)
                {
                    Swap(arr, i, j);
                    i++;
                    j--;
                }
            }

            if (i < rb)
            {
                QuickSort(arr, i, rb);
            }
            if (j > lb)
            {
                QuickSort(arr, lb, j);
            }
        }

        public static void MergeSort(int[] arr, int lb, int rb)
        {
            if (lb < rb)
            {
                int mid = (lb + rb) / 2;

                MergeSort(arr, lb, mid);
                MergeSort(arr, mid + 1, rb);

                Merge(arr, lb, mid, rb);
            }
        }

        private static void Merge(int[] arr, int lb, int mid, int rb)
        {
            int[] leftArr = new int[mid - lb + 1];
            int[] rightArr = new int[rb - mid];

            int i = 0;
            int j = 0;

            for (i = 0; i < leftArr.Length; i++)
            {
                leftArr[i] = arr[lb + i];
            }
            for (j = 0; j < rightArr.Length; j++)
            {
                rightArr[j] = arr[mid + 1 + j];
            }

            int k = lb;
            i = 0; j = 0;

            while (i < leftArr.Length && j < rightArr.Length)
            {
                if (leftArr[i] <= rightArr[j])
                {
                    arr[k] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[k] = rightArr[j];
                    j++;
                }
                k++;
            }

            while (i < leftArr.Length)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }
            while (j < rightArr.Length)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
        }

        public static int BinarySearch(int[] arr, int target)
        {
            int lb = 0;
            int rb = arr.Length - 1;


            while (lb <= rb)
            {
                int mid = (rb + lb) / 2;
                if (target < arr[mid])
                {
                    rb = mid - 1;
                }
                else if (target > arr[mid])
                {
                    lb = mid + 1;
                }
                else if (target == arr[mid])
                {
                    return mid;
                }
            }

            return -1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
