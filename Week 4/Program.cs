using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int num = 13;
            ToBinary(num);
            ToNumberSystem(28, 16);

            CustomList<int> customList = new CustomList<int>();

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);

            customList.Insert(40, 2);
            customList.RemoveAt(0);
            customList.Remove(5);

            Console.WriteLine(customList.Count);
            Console.WriteLine(customList[0]);

            for (int i = 0; i < customList.Count; i++)
            {
                Console.Write(customList[i] + " ");
            }
            Console.WriteLine();
            */

            LinkedList<int> linkedList = new LinkedList<int>();
            
            linkedList.Add(1);
            linkedList.Add(2);
            linkedList.Add(3);
            linkedList.Add(4);
            linkedList.Add(5);
            linkedList.Add(6);

            //linkedList.Remove(3);
            //linkedList.RemoveAt(1);
            linkedList.PrintList();
        }

        public static void ToBinary(int num)
        {
            int startNum = num;
            string binary = "";

            while (num != 0)
            {
                int remainder = num % 2;
                num /= 2;
                binary += remainder;
            }

            string finalBinary = "";
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                finalBinary += binary[i];
            }

            Console.WriteLine($"{startNum} -> {finalBinary}");
        }

        public static void ToNumberSystem(int num, int divisor)
        {
            int startNum = num;
            string code = "";

            while (num != 0)
            {
                int remainder = num % divisor;

                if (remainder > 9)
                {
                    char letter = Convert.ToChar(remainder + 55);
                    code += letter;
                }
                else
                {
                    code += remainder;
                }

                num /= divisor;
            }

            string finalCode = "";
            for (int i = code.Length - 1; i >= 0; i--)
            {
                finalCode += code[i];
            }

            Console.WriteLine($"{startNum} -> {finalCode}");
        }
    }
}
