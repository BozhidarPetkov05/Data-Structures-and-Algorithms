using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number (10 - 10010): ");
            n = int.Parse(Console.ReadLine());

            if (n < 10)
            {
                n = 10;
            }
            else if (n > 10010)
            {
                n = 10010;
            }

            Console.WriteLine($"Digit sum of {n} is {DigitsSum(n)}");
        }

        public static int DigitsSum(int n, int currentIndex = 0)
        {
            string stringifiedNum = n.ToString();
            
            if (currentIndex == stringifiedNum.Length - 1)
            {
                return int.Parse(stringifiedNum[currentIndex].ToString());
            }

            string currentNumString = stringifiedNum.Substring(currentIndex, 1);
            int currentNum = int.Parse(currentNumString);
            currentIndex++;

            return currentNum + DigitsSum(n, currentIndex);

        }
    }
}
