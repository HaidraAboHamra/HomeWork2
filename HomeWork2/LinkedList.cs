using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class LinkedList
    {
        private Node head;
        private Node tail;
        public int Count { get; private set; }

        public LinkedList()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public void AddFirst(object data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = tail = newNode;
            }
            else
            {
                newNode.Next = head;
                head = newNode;
            }
            Count++;
        }

        public void AddLast(object data)
        {
            Node newNode = new Node(data);
            if (tail == null)
            {
                head = tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
            Count++;
        }

        public void AddAt(int index, object data)
        {
            if (index < 0 || index > Count)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }

            if (index == 0)
            {
                AddFirst(data);
                return;
            }

            if (index == Count)
            {
                AddLast(data);
                return;
            }

            Node newNode = new Node(data);
            Node current = head;

            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
            Count++;
        }

        public void RemoveFirst()
        {
            if (head == null) throw new InvalidOperationException("List is empty.");

            head = head.Next;
            if (head == null) tail = null;
            Count--;
        }

        public void RemoveLast()
        {
            if (head == null) throw new InvalidOperationException("List is empty.");

            if (head == tail)
            {
                head = tail = null;
            }
            else
            {
                Node current = head;
                while (current.Next != tail)
                {
                    current = current.Next;
                }
                current.Next = null;
                tail = current;
            }
            Count--;
        }

        public void PrintList()
        {
            Node current = head;
            while (current != null)
            {
                // Print different types of data
                if (current.Data is string)
                {
                    Console.WriteLine("String: " + current.Data);
                }
                else if (current.Data is int)
                {
                    Console.WriteLine("Integer: " + current.Data);
                }
                else if (current.Data is byte[])
                {
                    Console.WriteLine("Image data: " + ((byte[])current.Data).Length + " bytes");
                }
                else
                {
                    Console.WriteLine("Other type: " + current.Data.ToString());
                }

                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}
