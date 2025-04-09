using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array_List;
using SinglyLinkedList;


namespace Hashtable
{
    private class keyValuePair<K, V>
    {
        public K key;
        public V value;

        public keyValuePair(K key, V value)
        {
            this.key = key;
            this.value = value;
        }
    }

    public class Hashtable<K,V>
    {
        public SinglyLinkedList<keyValuePair<K, V>>[] hashtable;

        private int count;
        private int alphaMin;
        private int alphaMax;


        public Hashtable(int size = 10, int alphaMin, int alphaMax){
            hashtable = new SinglyLinkedList<keyValuePair<K, V>>[size];
            this.count = 0;
            this.alphaMin = alphaMin;
            this.alphaMax = alphaMax;
        }

        private int Hash(K key, int size = hashtable.length)
        {
            return Math.Abs(key.GetHashCode()) % size;
        }

        public bool Remove(Func<T, bool> predicate)
        {
            SinglyLinkedListNode<T> current = Head;
            SinglyLinkedListNode<T> prev = null;

            while (current != null)
            {
                if (predicate(current.Data))
                {
                    if (prev == null)
                        Head = current.Next;
                    else
                        prev.Next = current.Next;

                    return true;
                }

                prev = current;
                current = current.Next;
            }

            return false;
        }

        public IEnumerable<T> GetItems()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }

    public class Hashtable<K, V>
    {
        private SinglyLinkedList<KeyValuePair<K, V>>[] hashtable;
        private int count;
        private int alphaMin;
        private int alphaMax;
        private const int MinSize = 4;

        public Hashtable(int size = 10, int alphaMin = 1, int alphaMax = 3)
        {
            hashtable = new SinglyLinkedList<KeyValuePair<K, V>>[size];
            this.alphaMin = alphaMin;
            this.alphaMax = alphaMax;
            count = 0;
        }

        private int Hash(K key, int size)
        {
            return Math.Abs(key.GetHashCode()) % size;
        }

        private double LoadFactor()
        {
            return (double)count / hashtable.Length;
        }

        public void Add(K key, V value)
        {
            int index = Hash(key, hashtable.Length);

            if (hashtable[index] == null)
            {
                hashtable[index] = new SinglyLinkedList<KeyValuePair<K, V>>();
            }

            hashtable[index].Add(new KeyValuePair<K, V>(key, value));
            count++;

            if (LoadFactor() > alphaMax)
            {
                rehash(hashtable.Length * 2);
            }
        }

        public bool Remove(K key)
        {
            int index = Hash(key, hashtable.Length);

            if (hashtable[index] != null)
            {
                bool removed = hashtable[index].Remove(kvp => kvp.key.Equals(key));
                if (removed)
                {
                    count--;
                    if (LoadFactor() < alphaMin && hashtable.Length > MinSize)
                    {
                        rehash(hashtable.Length / 2);
                    }
                }

                return removed;
            }

            return false;
        }

        public bool rehash(int newSize)
        {
            var newTable = new SinglyLinkedList<KeyValuePair<K, V>>[newSize];

            foreach (var list in hashtable)
            {
                if (list != null)
                {
                    foreach (var kvp in list.GetItems())
                    {
                        int index = Hash(kvp.key, newSize);

                        if (newTable[index] == null)
                        {
                            newTable[index] = new SinglyLinkedList<KeyValuePair<K, V>>();
                        }

                        newTable[index].Add(new KeyValuePair<K, V>(kvp.key, kvp.value));
                    }
                }
            }

            hashtable = newTable;
            return true;
        }
    }
}
}
