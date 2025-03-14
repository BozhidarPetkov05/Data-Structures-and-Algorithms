using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1 - 19): ");
            int n = int.Parse(Console.ReadLine());
            if (n < 1)
            {
                n = 1;
            }
            else if (n > 19)
            {
                n = 19;
            }

            double[] arr = new double[n];
            ArrayFiller(arr);
            double total = ArraySum(arr);
            Console.WriteLine("Total sum: " + total);
        }

        static void ArrayFiller(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter element at index {i}: ");
                double elm = double.Parse(Console.ReadLine());
                arr[i] = elm;
            }
        }

        static double ArraySum(double[] arr)
        {
            double total = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                total += arr[i];
            }

            return total;
        }
    }
}
