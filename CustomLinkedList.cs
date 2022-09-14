using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class CustomLinkedList
    {
        Node head;

        public void AddEnd(int newData)
        {
            Node newNode = new Node(newData);

            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked list is empty");

            }
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void AddFirst(int newData)
        {
            Node newNode = new Node(newData);
            newNode.next = head;
            this.head = newNode;
        }
    }
}
