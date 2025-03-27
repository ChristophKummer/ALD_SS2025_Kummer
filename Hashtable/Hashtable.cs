using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Array_List;
using SinglyLinkedList;

namespace Hashtable
{
    public class Hashtable<K,V>
    {
        private Array_List.ArrayList<SinglyLinkedList.SinglyLinkedList<Tuple<K, V>>> m_container;
        public void put(K key, V value)
        { 

        }

        public V get(K key)
        {
            return default(V);
        }

        public bool get(K key, out V value)
        {
            value = default(V);
            return false;
        } 
    }
}
