using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    public class DoubleLinkedListNode<T>
    {
        public DoubleLinkedListNode(T value)
        {
            Value = value;
        }
        public T Value { get; }

        public DoubleLinkedListNode<T> Previous { get; set; }
        public DoubleLinkedListNode<T> Next { get; set; }
    }

    public class DoubleLinkedList<T>
    {
        private DoubleLinkedListNode<T> head;
        private DoubleLinkedListNode<T> tail;
        private int count;

        public DoubleLinkedList()
        {
            head = null;
            tail = null;
            count = 0;
        }
        public int Count { get; private set; }

        public void Add(T value)
        {
            if (head == null)
            {
                DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(value);
                head = newNode;
                tail = newNode;
            }
            else
            {
                DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(value);
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
            }
            count++;
        }

        public void Remove(T value)
        {
            if (head != null)
            {
                DoubleLinkedListNode<T> currentNode = head;
                while (currentNode != null)
                {
                    if (currentNode.Value.Equals(value))
                    {
                        if (currentNode.Equals(head))
                        {
                            head = currentNode.Next;
                            if (head != null)
                            {
                                head.Previous = null;
                            }
                        }
                        else if (currentNode.Equals(tail))
                        {
                            tail = currentNode.Previous;
                            if (tail != null)
                            {
                                tail.Next = null;
                            }
                        }
                        else
                        {
                            currentNode.Previous.Next = currentNode.Next;
                            currentNode.Next.Previous = currentNode.Previous;
                        }
                        count--;
                        return;
                    }
                    currentNode = currentNode.Next;
                }
                Console.WriteLine("This node does not exist");
            }
        }

        public bool Find(T element)
        {
            DoubleLinkedListNode<T> currentNode = head;

            while (currentNode != null)
            {
                if (currentNode.Value.Equals(element))
                {
                    return true;
                }
                currentNode = currentNode.Next;
            }
            return false;
        }
        
        public void InsertAtIndex(int index, T value) {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Invalid index.");
                return;
            }

            DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(value);

            if (index == 0)
            {
                newNode.Next = head;
                head = newNode;

                if (tail == null)
                {
                    tail = newNode.Next;
                }
            }
            else
            {
                DoubleLinkedListNode<T> currentNode = head;
                for (int i = 0; i < index; i++)
                {
                    currentNode = currentNode.Next;
                }

                newNode.Next = currentNode;
                newNode.Previous = currentNode.Previous;

                currentNode.Previous.Next = newNode;
                currentNode.Next = currentNode.Next.Previous;
            }
            count++;
        }

        public T GetAtIndex(int index)
        {
            if (index < 0 || index >= count)
            {
                Console.WriteLine("Invalid index.");
                return default(T);
            }
            
            DoubleLinkedListNode<T> current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }

            return current.Value;
        }

        public T[] ToArray()
        {
            DoubleLinkedListNode<T> current = head;
            int count = 0;
            while (current != null)
            {
                current = current.Next;
                count++;
            }

            T[] arr = new T[count];
            current = head;
            for (int i = 0; i < count; i++)
            {
                arr[i] = current.Value;
                current = current.Next;
            }

            return arr;
        }

        public void Print()
        {
            DoubleLinkedListNode<T> current = head;
            while (current != null)
            {
                Console.Write(current.Value + "  ");
                current = current.Next;
            }
        }
    }
}
