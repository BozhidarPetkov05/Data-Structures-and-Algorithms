using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Linked_List
{
    public class CustomArrStack<T>
    {
        public int Count { get; private set; }

        private T[] Arr { get; set; }

        public CustomArrStack()
        {
            Arr = new T[0];
            Count = 0;
        }

        public void Push(T value)
        {
            T[] initialArr = Arr;
            T[] newArr = new T[Arr.Length + 1];
            Array.Copy(initialArr, newArr, Count);

            newArr[Count] = value;
            Arr = newArr;
            Count++;
        }

        public T Pop()
        {
            Count--;
            T[] initialArr = Arr;
            T[] newArr = new T[Count];
            
            Array.Copy(initialArr, newArr, Count);
            Arr = newArr;
            
            return initialArr[Count];
        }

        public T Peek()
        {
            return Arr[Count - 1];
        }

        public void PrintStack()
        {
            for (int i = Count - 1; i >= 0; i--)
            {
                Console.WriteLine(Arr[i]);
            }
        }
    }
}
