using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Linked_List
{
    public class LinkedList<T>
    {
        public int Count { get; private set; }
        public Node<T> Head { get; set; }
        public Node<T> Tail { get; set; }
        public LinkedList()
        {
            Count = 0;
            Head = null;
            Tail = null;
        }

        public void Add(T value)
        {
            Node<T> nodeToAdd;
            if (Head is null)
            {
                nodeToAdd = new Node<T>(value);
                
                Head = nodeToAdd;
                Tail = nodeToAdd;
            }
            else
            {
                nodeToAdd = new Node<T>(value, Tail);
                Tail = nodeToAdd;
            }

            Count++;
        }

        public void RemoveAtBeginning()
        {
            RemoveAt(0);
        }

        public void RemoveAtEnd()
        {
            RemoveAt(Count - 1);
        }

        public int IndexOf(T value)
        {
            Node<T> current = Head;
            int index = 0;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }

            return -1;
        }

        public void RemoveAt(int index)
        {
            Node<T> current = Head;
            Node<T> prev = null;
            int i = 0;

            if (index < Count)
            {
                if (index == 0)
                {
                    Head = current.Next;
                }
                else
                {
                    while (i < index)
                    {
                        prev = current;
                        current = current.Next;
                        i++;
                    }
                    prev.Next = current.Next;
                    if (current == Tail)
                    {
                        Tail = prev;
                    }
                }

                Count--;

            }
            else
            {
                Console.WriteLine("Invalid index!");
            }
        }

        public void RemoveByValue(T value)
        {
            int index = IndexOf(value);
            RemoveAt(index);
        }

        public void PrintList()
        {
            Node<T> current = Head;
            while (current != null)
            {
                if (current.Next is null)
                {
                    Console.Write(current.Value);
                }
                else
                {
                    Console.Write(current.Value + " -> ");
                }
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}
