using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FinalPrep
{
    public class LinkedList<T>
    {
        public LinkedListNode<T> Head { get; set; }
        public LinkedListNode<T> Tail { get; set; }
        public int Count { get; private set; }
        public LinkedList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public void Add(T value)
        {
            LinkedListNode<T> node = new LinkedListNode<T>(value);
            if (Head is null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
            }
            Count++;
        }

        public int IndexOf(T value)
        {
            int index = 0;
            
            LinkedListNode<T> current = Head;
            
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return index;
                }
                index++;
                current = current.Next;
            }

            return -1;
        }

        public void RemoveAt(int index)
        {
            LinkedListNode<T> current = Head;
            LinkedListNode<T> previous = null;
            int i = 0;

            while (current != null)
            {
                if (i == index)
                {
                    previous.Next = current.Next;
                    break;
                }

                i++;
                previous = current;
                current = current.Next;
            }

            Count--;
        }

        public void Remove(T value)
        {
            int index = IndexOf(value);
            if (index != -1)
            {
                RemoveAt(index);
            }
        }

        public void RemoveStart()
        {
            if (Head != null)
            {
                RemoveAt(0);
            }
            
        }

        public void RemoveEnd()
        {
            if (Head != null)
            {
                RemoveAt(Count - 1);
            }
        }
    }
}
