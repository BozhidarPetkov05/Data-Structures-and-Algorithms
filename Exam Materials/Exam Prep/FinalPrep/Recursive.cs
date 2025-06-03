using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrep
{
    public static class Recursive
    {
        public static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

        public static int Fibonacci(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2); 
        }

        public static void Hanoi(int disks, char rod1, char rod2, char rod3)
        {
            if (disks == 0)
            {
                return;
            }

            Hanoi(disks - 1, rod1, rod3, rod2);
            Console.WriteLine(rod1 + " -> " + rod2);
            Hanoi(disks - 1, rod3, rod2, rod1);
        }
    }
}
