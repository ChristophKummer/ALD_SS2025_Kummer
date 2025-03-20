using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SLL_Test
{
  internal class Program
  {
    private class Student
    {
      private int MatNr;
      private String Name;

      public override bool Equals(object obj)
      {
        Student other = (Student)obj;
        return other.MatNr.Equals(this.MatNr);
      }
    }
        static void Main(string[] args)
        {
            /*
      SinglyLinkedList.SinglyLinkedList<int> sll = 
        new SinglyLinkedList.SinglyLinkedList<int>();

      sll.Add(10);
      sll.Add(11);
      sll.Add(12);

      sll.Remove(11);
            */


            SinglyLinkedList.SinglyLinkedList<string> strVar = new SinglyLinkedList.SinglyLinkedList<string>();
            strVar.Add("Hello");
            strVar.Add("this");
            strVar.Add("is");
            strVar.Add("the");
            strVar.Add("sixth");
            strVar.Add("variable.");

            //Überprüfung ob Elemente in der Liste sind
            string[] strArr = new string[] { "Hello", "this", "is", "the", "sixth", "variable." };

            for (int i = 0; i < strArr.Length; i++)
            {
                if (strVar.Contains(strArr[i]))
                {
                    Console.WriteLine("Element " + strArr[i] + " is in the list.");
                }
                else
                {
                    Console.WriteLine("Element " + strArr[i] + " is not in the list.");
                }
            }


            Console.WriteLine();
            Console.WriteLine();
            //Überprüfung welches Element an der jeweiligen Stelle ist
            for (int j = strArr.Count()-1 ; j >= 0; j--)
            {
                Console.WriteLine("Element at position " + j + " is: " + strVar.FindByIndex(j));
            }

            Console.WriteLine();
            Console.WriteLine();
            //Lösche das 4. und 6. Element
            strVar.Remove("the");
            strVar.Remove("sixth");
            //Überprüfung ob Elemente in der Liste sind
            for (int i = 0; i < strArr.Length; i++)
            {
                if (strVar.Contains(strArr[i]))
                {
                    Console.WriteLine("Element " + strArr[i] + " is in the list.");
                }
                else
                {
                    Console.WriteLine("Element " + strArr[i] + " is not in the list.");
                }
            }


        }
    }
}
