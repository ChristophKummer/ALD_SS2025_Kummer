using System;
using System.Diagnostics;
using SinglyLinkedList;

namespace Array_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList.SinglyLinkedList<string> strVarSLL = new SinglyLinkedList.SinglyLinkedList<string>();
            ArrayList<string> strVarAL = new ArrayList<string>(5);
            //Zeitmessung RemoveAt Array_List
            Stopwatch timeSLL = new Stopwatch();
            Stopwatch timeAL = new Stopwatch();
            timeSLL.Start();
            strVarSLL.Add("Das");
            strVarSLL.Add("ist");
            strVarSLL.Add("ein");
            strVarSLL.Add("neuer");
            strVarSLL.Add("Eintrag");
            timeSLL.Stop();
            Console.WriteLine("Time for Add SLL: " + timeSLL);

            timeAL.Start();
            strVarAL.Add("Das");
            strVarAL.Add("ist");
            strVarAL.Add("ein");
            strVarAL.Add("neuer");
            strVarAL.Add("Eintrag");
            timeAL.Stop();
            Console.WriteLine("Time for Add AL: " + timeAL);

            timeSLL.Reset();
            timeAL.Reset();

            timeSLL.Start();
            //strVarSLL.RemoveAt(2);
            timeSLL.Stop();
            Console.WriteLine("Time for RemoveAt SLL: " + timeSLL);

            timeAL.Start();
            strVarAL.RemoveAt(2);
            timeAL.Stop();
            Console.WriteLine("Time for RemoveAt AL: " + timeAL);



        }
    }
}
