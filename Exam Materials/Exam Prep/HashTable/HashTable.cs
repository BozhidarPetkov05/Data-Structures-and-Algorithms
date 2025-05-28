using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class HashTable<K, V>
    {
        private int Size { get; set; }
        private LinkedList<HashEntry<K, V>>[] Pairs { get; set; }

        public HashTable(int size = 64)
        {
            Size = size;
            Pairs = new LinkedList<HashEntry<K, V>>[size];
        }

        public int Hash(K key)
        {
            return Math.Abs(key.GetHashCode() % Size);
        }

        public void Add(K key, V value)
        {
            int index = Hash(key);
            LinkedList<HashEntry<K, V>> linkedList = GetLinkedList(index);
            HashEntry<K, V> entry = new HashEntry<K, V>() { Key = key, Value = value };
            linkedList.AddLast(entry);
        }

        public void Remove(K key)
        {
            int index = Hash(key);
            LinkedList<HashEntry<K, V>> linkedList = GetLinkedList(index);

            bool itemFound = false;
            HashEntry<K, V> entry = default(HashEntry<K, V>);

            foreach (HashEntry<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    entry = item; 
                }
            }

            if (itemFound)
            {
                linkedList.Remove(entry);
            }
        }

        public V Find(K key, V value)
        {
            int index = Hash(key);
            LinkedList<HashEntry<K, V>> linkedList = GetLinkedList(index);
            foreach (HashEntry<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    return item.Value;
                }
            }
            return default(V);
        }

        public LinkedList<HashEntry<K, V>> GetLinkedList(int index)
        {
            LinkedList<HashEntry<K, V>> linkedList = Pairs[index];
            if (linkedList == null)
            {
                linkedList = new LinkedList<HashEntry<K, V>>();
                Pairs[index] = linkedList;
            }
            return linkedList;
        }

        public void Print()
        {
            for (int i = 0; i < Size; i++)
            {
                LinkedList<HashEntry<K, V>> current = GetLinkedList(i);
                foreach (HashEntry<K, V> item in current)
                {
                    Console.WriteLine($"Key: {item.Key} - Value: {item.Value}");
                }
            }
        }
    }
}
