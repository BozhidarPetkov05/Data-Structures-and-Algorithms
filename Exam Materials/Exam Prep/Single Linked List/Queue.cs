using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Linked_List
{
    public class Queue<T>
    {
        public int Count { get; private set; }
        private T[] Arr { get; set; }

        public Queue()
        {
            Arr = new T[0];
            Count = 0;
        }

        public void Enqueue(T value)
        {
            T[] initialArr = Arr;
            T[] newArr = new T[Count + 1];

            Array.Copy(initialArr, newArr, Count);
            newArr[Count] = value;
            Arr = newArr;
            Count++;
        }

        public T Dequeue() 
        {
            T[] initialArr = Arr;
            T[] newArr = new T[Count - 1];

            for (int i = 1; i < Count; i++)
            {
                newArr[i - 1] = initialArr[i];
            }
            Count--;
            Arr = newArr;
            return initialArr[0];
        }

        public T Peek()
        {
            return Arr[0];
        }

        public void PrintQueue()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(Arr[i]);
            }
        }
    }
}
