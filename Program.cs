using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //LinkedList<int> list = new LinkedList<int>();
            //list.AddLast(56);
            //list.AddLast(30);
            //list.AddLast(70);

            //foreach (int ele in list)
            //{
            //    Console.WriteLine(ele);
            //}
            //Console.ReadLine();

           
            CustomLinkedList customLinkedList = new CustomLinkedList();
            customLinkedList.AddFirst(70);
            customLinkedList.AddFirst(56);
            Console.WriteLine("Element added before head node 70");
            customLinkedList.Display();

            //CustomLinkedList customLinkedList1 = new CustomLinkedList();
            //customLinkedList1.AddEnd(56);
            //customLinkedList1.AddEnd(30);
            //customLinkedList1.AddEnd(70);
            //Console.WriteLine();
            //Console.WriteLine("Element added after head node 56");
            //customLinkedList1.Display();

            Console.WriteLine("Inserting an element in list");
            customLinkedList.InsertInBetween(30, 2);
            customLinkedList.Display();

            //Console.WriteLine("Deleted first element from list");
            //customLinkedList.DeleteFirstNode();

            Console.WriteLine("Deleting last node from list");
            customLinkedList.DeleteLastNode();
            customLinkedList.Display();
            Console.ReadLine();
        }
    }
}
