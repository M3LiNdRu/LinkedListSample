using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            //Fill the list
            for (int i = 1; i <= 10; i++)
            {
                Node n = new Node(i);
                list.Append(n);
            }

            //Print Nodes
            list.PrintAllNodes();

            //Get Nth Node from the end (iterative)
            Node n2 = list.GetNthNodeFromEndIterative(1); 
            n2.PrintInfo();

            //Get Nth Node from the end (recursive)
            Node n3 = list.GetNthNodeFromEndRecursive(3);
            n3.PrintInfo();

            //Get Nth from the begin
            Node n4 = list.GetNthNode(1);
            n4.PrintInfo();

            //Remove the Node
            list.Remove(n3);

            //Print all Nodes again
            list.PrintAllNodes();

            Console.ReadLine();
        }
    }
}
