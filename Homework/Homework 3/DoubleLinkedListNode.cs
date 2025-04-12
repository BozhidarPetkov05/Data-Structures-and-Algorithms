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
                newNode.Next = newNode;
                newNode.Previous = newNode;
            }
            else
            {
                DoubleLinkedListNode<T> newNode = new DoubleLinkedListNode<T>(value);
                
                tail.Next = newNode;
                newNode.Previous = tail;
                tail = newNode;
                
                head.Previous = tail;
                newNode.Next = head;
            }
            count++;
        }
        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
                return;
            }

            var current = head;
            do
            {
                Console.Write(current.Value + " ");
                current = current.Next;
            }
            while (current != head);

            Console.WriteLine();
        }
    }
}
