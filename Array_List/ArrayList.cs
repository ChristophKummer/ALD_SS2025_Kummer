using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List
{
    public class ArrayList<T>
    {
        private T[] array;
        public ArrayList(int size)
        {
            array = new T[size];
        }
        
        public int Add(T item)
        {
            Array.Resize(ref array, array.Length + 1);
            array[array.Length - 1] = item;
            return array.Length;
        } 

        public void InsertAt(int index, T item)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException();
            }
            Array.Resize(ref array, array.Length + 1);
            for (int i = array.Length - 1; i > index; i--)
            {
                array[i] = array[i - 1];
            }
            array[index] = item;
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= array.Length)
            {
                throw new IndexOutOfRangeException();
                return false;
            }
            for (int i = index; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            Array.Resize(ref array, array.Length - 1);
            return true;
        }

        public void Clear()
        {
            Array.Resize(ref array, 0);
        }

        public int Count()
        {
            return array.Length;
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= array.Length)
                {
                    throw new IndexOutOfRangeException();
                }
                array[index] = value;
            }
        }
    }
}
