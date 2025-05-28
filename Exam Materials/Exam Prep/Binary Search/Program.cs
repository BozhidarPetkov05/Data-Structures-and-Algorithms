namespace Binary_Search
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
            BinarySearch(arr, 1);
        }

        public static void BinarySearch(int[] arr, int num)
        {
            bool isFound = false;
            int start = 0;
            int end = arr.Length - 1;

            int middle = -1;

            while (start <= end)
            {
                middle = (start + end) / 2;
                if (arr[middle] == num)
                {
                    isFound = true;
                    break;
                }
                
                if (num > arr[middle])
                {
                    start = middle + 1;
                }
                else if (num < arr[middle])
                {
                    end = middle - 1;
                }
            }

            if (isFound)
            {
                Console.WriteLine($"{num} was found at index {middle}");
            }
            else
            {
                Console.WriteLine($"{num} was not found in the array!");
            }
        }
    }
}