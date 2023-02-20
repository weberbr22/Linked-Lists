using System;
using System.Text;

namespace LinkedLists // Note: actual namespace depends on the project name.
{
    public class IntegerLinkedList
    {
        private Node head;
        private int count;

        public IntegerLinkedList()
        {
            head = null;
            count = 0;
        }

        public void Append(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
        }

        public bool Remove(int value)
        {
            if (head == null)
            {
                return false;
            }
            if (head.Value == value)
            {
                head = head.Next;
                count--;
                return true;
            }
            Node current = head;
            while (current.Next != null)
            {
                if (current.Next.Value == value)
                {
                    current.Next = current.Next.Next;
                    count--;
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public int Sum()
        {
            int sum = 0;
            Node current = head;
            while (current != null)
            {
                sum += current.Value;
                current = current.Next;
            }
            return sum;
        }

        public int Length()
        {
            return count;
        }

        public void Join(IntegerLinkedList otherList)
        {
            if (otherList == null || otherList.head == null)
            {
                return;
            }
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = otherList.head;
            count += otherList.count;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            Node current = head;
            while (current != null)
            {
                sb.Append(current.Value);
                if (current.Next != null)
                {
                    sb.Append(", ");
                }
                current = current.Next;
            }
            sb.Append("]");
            return sb.ToString();
        }

        private class Node
        {
            public int Value;
            public Node Next;

            public Node(int value)
            {
                Value = value;
                Next = null;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
    }
}