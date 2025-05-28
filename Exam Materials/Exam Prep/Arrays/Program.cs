namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] arr;

            //int[] arr = new int[5];

            //int[] arr = new int[] { 2, 3, 5, 7, 11 };

            int[] arr = { 2, 3, 5, 7, 11 };
            Console.WriteLine("First element: " + arr[0]);
            Console.WriteLine("Last element: " + arr[arr.Length - 1]);
            Console.WriteLine("Array length: " + arr.Length);


            int[,] matrix = new int[,]
            {
                { 1, 2, 3, 4 },
                { 5, 6, 7, 8 }
            };

            Console.WriteLine("Rows: " + matrix.GetLength(0));
            Console.WriteLine("Columns: " + matrix.GetLength(1));

        }
    }
}