using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClosestPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Enter a number (10 - 100010): ");
            n = int.Parse(Console.ReadLine());
            if (n < 10)
            {
                n = 10;
            }
            else if (n > 100010)
            {
                n = 100010;
            }

            Console.WriteLine($"Closest bigger prime number to {n}: {ClosestPrime(n)}");
        }

        public static int ClosestPrime(int n)
        {
            int current = n + 1;
            while (true)
            {
                bool isPrime = true;

                for (int i = 2; i < current / 2; i++)
                {
                    if (current % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    return current;
                }
                else
                {
                    current++;
                }
            }
        }
    }
}
