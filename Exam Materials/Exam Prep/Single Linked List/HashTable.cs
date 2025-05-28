using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Linked_List
{
    public class HashTable<K, V>
    {
        private int Size { get; set; }
        private System.Collections.Generic.LinkedList<HashEntry<K, V>>[] Items { get; set; }

        public HashTable(int size = 64)
        {
            Size = size;
            Items = new System.Collections.Generic.LinkedList<HashEntry<K, V>>[Size];
        }

        private int Hash(K key)
        {
            int index = Math.Abs(key.GetHashCode() % Size);
            return index;
        }

        public void Add(K key, V value)
        {
            int index = Hash(key);
            System.Collections.Generic.LinkedList<HashEntry<K, V>> linkedList = GetLinkedList(index);
            HashEntry<K, V> item = new HashEntry<K, V> { Key = key, Value = value };
            linkedList.AddLast(item);
        }

        public void Remove(K key)
        {
            int index = Hash(key);
            System.Collections.Generic.LinkedList<HashEntry<K, V>> linkedList = GetLinkedList(index);
            bool itemFound = false;
            HashEntry<K, V> foundItem = default(HashEntry<K, V>);
            foreach (HashEntry<K, V> item in linkedList)
            {
                if (item.Key.Equals(key))
                {
                    itemFound = true;
                    foundItem = item;
                }
            }

            if (itemFound)
            {
                linkedList.Remove(foundItem);
            }
        }

        protected System.Collections.Generic.LinkedList<HashEntry<K, V>> GetLinkedList(int position)
        {
            System.Collections.Generic.LinkedList<HashEntry<K, V>> linkedList = Items[position];
            if (linkedList == null)
            {
                linkedList = new System.Collections.Generic.LinkedList<HashEntry<K, V>>();
                Items[position] = linkedList;
            }

            return linkedList;
        }
    }
}
