using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrep
{
    public class CustomQueue<T>
    {
        public int Count { get; private set; }

        private T[] Arr { get; set; }

        public CustomQueue()
        {
            Arr = new T[0];
            Count = 0;
        }

        public void Enqueue(T item)
        {
            T[] newArr = new T[Arr.Length + 1];

            for (int i = 0; i < newArr.Length - 1; i++)
            {
                newArr[i] = Arr[i];
            }

            newArr[Arr.Length - 1] = item;
            Arr = newArr;
            Count++;
        }

        public T Dequeue()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            T[] newArr = new T[Arr.Length - 1];
            T item = Arr[0];

            for (int i = 1; i < Arr.Length; i++)
            {
                newArr[i - 1] = Arr[i];
            }

            Count--;
            Arr = newArr;
            return item;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            return Arr[0];
        }
    }
}
