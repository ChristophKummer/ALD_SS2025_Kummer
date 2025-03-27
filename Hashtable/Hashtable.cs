using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SinglyLinkedList;
using ArrayList;

namespace Hashtable
{
    internal class Hashtable<K, V>
    {
        private ArrayList.ArrayList<SinglyLinkedList.SinglyLinkedList<Tuple<K,V>>> m_container;
        public void put(K key, V value)
        {
            key.GetHashCode();
        }

        public V get(K key)
        {
            return default(V);
        }

        public bool get(K key, out V value)
        {
            value = default(V);
            return true;
        }
    }
}
