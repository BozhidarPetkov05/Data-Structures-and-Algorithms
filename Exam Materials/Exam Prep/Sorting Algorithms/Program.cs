namespace Sorting_Algorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 50, 1, -9, 41, 6, 2, 9 };
            //BubbleSort(arr);
            //SelectionSort(arr);
            //InsertionSort(arr);
            QuickSort(arr, 0, arr.Length - 1);
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

        public static void BubbleSort(int[] arr)
        {
            bool isSwapped;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                isSwapped = false;
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    //Comparing each element with the next element and swapping their positions
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        isSwapped = true;
                    }
                }
                if (!isSwapped)
                {
                    break;
                }
            }
        }

        public static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                
                //finding the index of the minimal element
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                //swapping the elements
                if (minIndex != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        public static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i]; //the key we compare
                int j = i - 1; //the element just before the key

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j]; //we shift the positions by one
                    j--;
                }
                arr[j + 1] = key; //we put the key on the corresponding position
            }
        }

        public static void QuickSort(int[] arr, int lb, int rb)
        {
            int leftIndex = lb;
            int rightIndex = rb;
            int pivot = arr[(lb + rb) / 2];

            while (leftIndex <= rightIndex)
            {
                while (leftIndex <= rb && arr[leftIndex] < pivot)
                {
                    leftIndex++;
                }
                while (lb <= rightIndex && arr[rightIndex] > pivot)
                {
                    rightIndex--;
                }
                if (leftIndex <= rightIndex)
                {
                    Swap(arr, leftIndex, rightIndex);
                    leftIndex++;
                    rightIndex--;
                }
            }

            if (leftIndex < rb)
            {
                QuickSort(arr, leftIndex, rb);
            }
            if (lb < rightIndex)
            {
                QuickSort(arr, lb, rightIndex);
            }
        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void MergeSort(int[] arr, int leftIndex, int rightIndex)
        {
            if (leftIndex < rightIndex)
            {
                int middle = (leftIndex + rightIndex) / 2;
                MergeSort(arr, leftIndex, middle);
                MergeSort(arr, middle + 1, rightIndex);
                MergeArray(arr, leftIndex, middle, rightIndex);
            }
        }

        public static void MergeArray(int[] arr, int start, int middle, int end)
        {
            int n1 = middle - start + 1;
            int n2 = end - middle;

            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            int i, j;

            for (i = 0; i < n1; i++)
            {
                leftArr[i] = arr[start + i];
            }
            for (j = 0; j < n2; j++)
            {
                rightArr[j] = arr[middle + j + 1];
            }

            i = 0;
            j = 0;


            int tracker = start;
            while (i < n1 && j < n2)
            {
                if (leftArr[i] < rightArr[j])
                {
                    arr[tracker] = leftArr[i];
                    i++;
                }
                else
                {
                    arr[tracker] = rightArr[j];
                    j++;
                }
                tracker++;
            }

            while (i < n1)
            {
                arr[tracker] = leftArr[i];
                i++;
                tracker++;
            }

            while (j < n2)
            {
                arr[tracker] = rightArr[j];
                j++;
                tracker++;
            }
        }
    }
}