using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkedListSample
{
   

    public class LinkedList
    {
        private Node head;
      
        public void Append(Node n)
        {
            this.append(this.head, n);
        }

        private void append(Node current, Node elm) {

            if (current == null) this.head = elm;
            else if (current.next == null) current.next = elm;
            else append(current.next, elm);
        }

        public void Remove(Node n)
        {
            Node previous = head;
            Node current = head;
            bool finish = false;
            while (!finish)
            {
                if (current.data.Equals(n.data))
                {
                    previous.next = current.next;
                    finish = true;
                }
                else if (current != null)
                {
                    previous = current;
                    current = current.next;
                }
                else finish = true;               
            }
        }

        public Node GetNthNode(int pos)
        {
            return getNthNode(this.head, pos);
        }
        
        private Node getNthNode(Node current, int pos)
        {
            if (pos == 1) return current;
            return getNthNode(current.next, pos - 1);
        }

        //Iterative method
        public Node GetNthNodeFromEndIterative(int n)
        {
            //If it's first element
            if (this.head == null || n < 1) return null;
            
            Node p1 = head;
            Node p2 = head;

            for (int j = 0; j < n - 1; ++j)
            { 
                // skip n-1 steps ahead
                if (p2 == null) return null; // not found since list size < n
                p2 = p2.next;
            }

            while (p2.next != null)
            {
                p1 = p1.next;
                p2 = p2.next;
            }

            return p1;
        }

        //Recursive method
        public Node GetNthNodeFromEndRecursive(int n)
        {
            int pos = this.getDepth(this.head) - (n-1);
            return this.getNthNode(this.head, pos);
        }

        public int GetDepth()
        {
            return this.getDepth(this.head);
        }

        private int getDepth(Node first)
        {
            if (first == null) return 0;
            return getDepth(first.next) + 1;
        }

        public void PrintAllNodes()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }

            Console.Write("\n");
        }
    }

    public class Node
    {
        public Node next { get; set; }
        public int data { get; set; }

        public Node(int data) { this.data = data; this.next = null; }
        public void PrintInfo() {
            Console.WriteLine(this.data);
        }

    }

    
}
