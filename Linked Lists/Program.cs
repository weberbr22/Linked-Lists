using System;

namespace LinkedLists // Note: actual namespace depends on the project name.
{
    internal class LL<T>
    {
        private Node head = null;

        private class Node
        {
            internal T data;
            internal Node next;

            internal Node(T value)
            {
                this.data = value;
                this.next = null;
            }
        }

        public LL()
        {
            this.head = null;
        }

        public void insertFront(T n)
        {
            Node newNode = new Node(n);
            newNode.next = this.head;
            this.head = newNode;
            
        }

        public void Add(T n)
        {
            Node new_node = new Node(n);

        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
        }
    }
}