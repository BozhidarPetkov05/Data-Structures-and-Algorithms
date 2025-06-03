using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings
{
    public static class Sorter
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
                int current = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > current)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[++j] = current;
            }
        }

        public static void QuickSort(int[] arr, int lb, int rb)
        {
            int pivot = arr[(lb + rb) / 2];
            
            int i = lb;
            int j = rb;

            while (i <= j)
            {
                while (arr[i] < pivot && i <= rb)
                {
                    i++;
                }
                while (arr[j] > pivot && j >= lb)
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
                int middle = (lb + rb) / 2;

                MergeSort(arr, lb, middle);
                MergeSort(arr, middle + 1, rb);

                Merge(arr, lb, middle, rb);
            }
        }

        private static void Merge(int[] arr, int lb, int middle, int rb)
        {
            int n1 = middle - lb + 1;
            int n2 = rb - middle;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            int i;
            int j;

            for (i = 0; i < n1; i++)
            {
                leftArr[i] = arr[lb + i];
            }
            for (j = 0; j < n2; j++)
            {
                rightArr[j] = arr[j + middle + 1];
            }

            i = 0;
            j = 0;
            int k = lb;

            while (i < n1 && j < n2)
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

            while (i < n1)
            {
                arr[k] = leftArr[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = rightArr[j];
                j++;
                k++;
            }
        }

        private static void Swap(int[] arr, int i1, int i2)
        {
            int temp = arr[i1];
            arr[i1] = arr[i2];
            arr[i2] = temp;
        }
    }
}
