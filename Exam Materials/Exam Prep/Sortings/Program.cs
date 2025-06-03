namespace Sortings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bubble Sort:");
            int[] bubbleSort = { 9, 1, 2, 96, -5, 12 };
            Sorter.BubbleSort(bubbleSort);
            PrintArr(bubbleSort);
            BreakLine();

            Console.WriteLine("Selection Sort:");
            int[] selectionSort = { 9, 1, 2, 96, -5, 12 };
            Sorter.SelectionSort(selectionSort);
            PrintArr(selectionSort);
            BreakLine();

            Console.WriteLine("Insertion Sort:");
            int[] insertionSort = { 9, 1, 2, 96, -5, 12 };
            Sorter.InsertionSort(insertionSort);
            PrintArr(insertionSort);
            BreakLine();

            Console.WriteLine("Quick Sort:");
            int[] quickSort = { 9, 1, 2, 96, -5, 12 };
            Sorter.QuickSort(quickSort, 0, quickSort.Length - 1);
            PrintArr(quickSort);
            BreakLine();

            Console.WriteLine("Merge Sort:");
            int[] mergeSort = { 9, 1, 2, 96, -5, 12 };
            Sorter.MergeSort(mergeSort, 0, mergeSort.Length - 1);
            PrintArr(mergeSort);
            BreakLine();

            Console.WriteLine("Fibonacci:");
            int n1 = 6; 
            Console.WriteLine($"Fibbonaci of {n1}: " + Recursion.Fibonacci(n1));
            BreakLine();

            Console.WriteLine("Factorial:");
            int n2 = 5;
            Console.WriteLine($"Factorial of {n2}: " + Recursion.Factorial(n2));
            BreakLine();

            Console.WriteLine("Power to:");
            int n3 = 3;
            int power = 3;
            Console.WriteLine($"{n3} to the power of {power} is: " + Recursion.PowerTo(n3, power));
        }

        public static void PrintArr(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void BreakLine()
        {
            Console.WriteLine("----------------------");
        }
    }
}