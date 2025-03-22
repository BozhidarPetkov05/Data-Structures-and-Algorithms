using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4
{
    public class CustomList<T>
    {
        private T[] arr { get; set; }
        private int count;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public CustomList()
        {
            arr = new T[0];
            count = 0;
        }

        public void Insert(T elm, int index)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }

            int length = arr.Length + 1;
            T[] newArr = new T[length];
            int tracker = 0;

            for (int i = 0; i < length; i++)
            {
                if (i == index)
                {
                    newArr[i] = elm;
                }
                else
                {
                    newArr[i] = arr[tracker];
                    tracker++;
                }
            }
            count++;
            arr = newArr;
        }

        public void Add(T elm)
        {
            Insert(elm, arr.Length);
        }

        public int FirstIndexOf(T elm)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Equals(elm))
                {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > count)
            {
                throw new IndexOutOfRangeException();
            }

            int length = arr.Length - 1;
            T[] newArr = new T[length];
            bool isSkipped = false;

            for (int i = 0; i < length; i++)
            {
                if (i == index)
                {
                    isSkipped = true;
                }
                if (isSkipped)
                {
                    newArr[i] = arr[i + 1];
                }
                else
                {
                    newArr[i] = arr[i];
                }
            }

            count--;
            arr = newArr;
        }

        public void Remove(T elm)
        {
            RemoveAt(FirstIndexOf(elm));
        }

        public T this[int index]
        {
            get
            {
                return arr[index];
            }
            set
            {
                arr[index] = value;
            }
        }
    }
}
