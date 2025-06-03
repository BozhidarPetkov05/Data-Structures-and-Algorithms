using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sortings
{
    public static class Recursion
    {
        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        public static int PowerTo(int a, int power)
        {
            if (power <= 0)
            {
                return 1;
            }
            return a * PowerTo(a, power - 1);
        }

        public static int BinarySearch(int[] arr, int low, int high, int target)
        {
            if (high >= low)
            {
                int mid = (high + low) / 2;
                if (target == arr[mid])
                {
                    return mid;
                }

                if (target < arr[mid])
                {
                    return BinarySearch(arr, low, mid - 1, target);
                }
                
                return BinarySearch(arr, mid + 1, high, target);
            }

            return -1;
        }
    }
}
