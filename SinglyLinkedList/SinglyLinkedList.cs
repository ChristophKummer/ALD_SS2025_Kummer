using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
  public class SinglyLinkedList<T>
  {
    //
    public SinglyLinkedList()
    {
      head = null;
      tail = null;
      count = 0;
    }
    
    private class Node<T>
    {
      public Node(T value)
      {
        this.Value = value;
      }
      public T Value { get; private set; }
      public Node<T> next { get; set; }
    }

    Node<T> head;
    Node<T> tail;
    int count;

        public void Add(T value)
        {   
            count++;
            if (head == null) //list is empty
            {
                Node<T> element = new Node<T>(value);
                head = element;
                //head.Value = value;
                tail = head;
                return;
            }

            //constant
            tail.next = new Node<T>(value);
            //tail.next.Value = value;
            tail = tail.next;

            //linar
            //Node<T> current = head;
            //while (current.next != null)
            //{
            //  current = current.next;
            //}

            ////current is the last element of the list
            //current.next = new Node<T>();
            //current.next.Value = value;
        }
        public bool Contains(T value)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return true;
                }
                current = current.next;
            }
            return false;
        }
        //Das Löschen des letzten Elements ist nicht möglich, da der tail nicht auf das vorletzte Element zeigt
        public bool Remove(T value)
        {
            if (head == null) return false; //in case of empty list

            Node<T> prev = null;
            Node<T> current = head;
            while (current.next != null)
            {
                if (current.Value.Equals(value))
                {
                    if (current == head)
                    {
                        head = head.next; //ein head wird benötigt, damit die Liste nicht leer ist
                    }
                    else
                    {
                        prev.next = current.next;
                    }
                    count--;
                    return true;
                }
                prev = current;
                current = current.next;
            }
            return false;
        }
        public bool IsObjectAtIndex(T value, int index)
        {
            //IsObjectAtIndex überprüft ob das Objekt an der Stelle index im SinglyLinkedList vorhanden ist
            Node<T> current = head;
            int i = 0;
            while (current != null)
            {
                if (i == index)
                {
                    if (current.Value.Equals(value))
                    {
                        return true;
                    }
                    return false;
                }
                i++;
                current = current.next;
            }
            return false;
        }
        public T FindByIndex(int index)
        {
            //FindByIndex gibt das Objekt an der Stelle index im SinglyLinkedList zurück
            Node<T> current = head;
            int i = 0;
            while (current != null) //solange current nicht null ist (also solange es noch ein Element gibt)
                                    //((kann an der aktuellen Stelle "null" sein aber an der folgenden Stelle != "null"?))
            {
                if (i == index)
                {
                    return current.Value;
                }
                i++;
                current = current.next;
            }
            return default(T); //
        }
        public int Count()
        {
            return count;
        }
        int Size()
        {
            return count;
        }    
        public void Clear()
        {
            head = null;
            tail = null;
            count = 0;
        }

  }
}
