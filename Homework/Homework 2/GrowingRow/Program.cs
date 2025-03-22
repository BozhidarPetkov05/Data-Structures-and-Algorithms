using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrowingRow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] arr = new double[9];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter a number at index {i}: ");
                double num = double.Parse(Console.ReadLine());

                if (num < -99.99)
                {
                    num = -99.99;
                }
                else if (num > 99.99)
                {
                    num = 99.99;
                }

                arr[i] = num;
            }

            if (IsGrowing(arr))
            {
                Console.WriteLine("The row is monotonically increasing");
            }
            else
            {
                Console.WriteLine("The row is not monotonically increasing");
            }
        }

        public static bool IsGrowing(double[] arr, int index = 0)
        {
            if (index == arr.Length - 1)
            {
                return true;
            }
            if (arr[index] > arr[index + 1])
            {
                return false;
            }
  
            return IsGrowing(arr, index + 1);
        }
    }
}
