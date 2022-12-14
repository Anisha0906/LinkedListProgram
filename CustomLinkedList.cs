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
        public void InsertInBetween(int data, int position)
        {
            Node newNode = new Node(data);
            newNode.data = data;
            newNode.next = null;

            if (position < 1)
            {
                Console.WriteLine("position should be greater");
            }
            else if (position == 1)
            {
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node tempNode = new Node(data);
                tempNode = this.head;
                while (position > 2)
                {
                    tempNode = tempNode.next;
                    position--;
                }
                newNode.next = tempNode.next;
                tempNode.next = newNode;
            }
        }
        public int DeleteFirstNode()
        {
            if (this.head == null)
            {
                Console.WriteLine("linked list is empty");
                return 0;
            }
            int deleteNode = this.head.data;
            this.head = this.head.next;
            return deleteNode;
        }
        public int DeleteLastNode()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                return 0;
            }
            if (this.head.next == null)
            {
                 return 0;
            }
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            int lasteleteNode = newNode.next.data;           
            newNode.next = null;
            return lasteleteNode;
        }
        public int Search(int value)
        {
            Node temp = this.head;


            while (temp != null)
            {
                if (temp.data == value)
                {
                    return value;
                }

                temp = temp.next;

            }
            return 0;
        }
    }
}
