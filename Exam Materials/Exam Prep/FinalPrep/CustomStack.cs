using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrep
{
    public class CustomStack<T>
    {
        public int Count { get; private set; }

        private T[] Arr { get; set; }

        public CustomStack()
        {
            Arr = new T[0];
            Count = 0;
        }

        public void Push(T item)
        {
            T[] newArr = new T[Arr.Length + 1];

            for (int i = 0; i < Arr.Length; i++)
            {
                newArr[i] = Arr[i];
            }

            newArr[newArr.Length - 1] = item;
            Arr = newArr;
            Count++;
        }

        public T Pop() 
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            T[] newArr = new T[Arr.Length - 1];
            T item = Arr[Arr.Length - 1];

            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = Arr[i];
            }

            Arr = newArr;
            Count--;
            return item;
        }

        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException("Stack is empty");
            }

            return Arr[Arr.Length - 1];
        }
    }
}
