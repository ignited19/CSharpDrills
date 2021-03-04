using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Drills
{
    class Tree
    {
        public static void createTree()
        {
            Node root = new Node("root");
            Node a = new Node("a");
            Node b = new Node("b");
            Node c = new Node("c");
            Node d = new Node("d");
            Node e = new Node("e");
            Node f = new Node("f");


            //Console.WriteLine(a.id);

            root.addChildren(a, b);
            a.addChildren(c, d);
            b.addChildren(e, f);

            //viewTree(root);
            printTreeLevelOrder(root);
            
        }

        public static void viewTree(Node root)
        {
            if (root == null)
                return;
            Console.WriteLine(root.id);
            viewTree(root.children[0]);
            viewTree(root.children[1]);
        }

        public static void printTreeLevelOrder(Node root)
        {
            if (root == null)
                return;

            LinkedList<Node> Queue = new LinkedList<Node>();

            Queue.AddFirst(root);

            while (Queue.Count != 0)
            {
                Node currentNode = Queue.First.Value;
                Console.WriteLine(currentNode.id);

                if (currentNode.children[0] != null)
                    Queue.AddLast(currentNode.children[0]);
                
                if (currentNode.children[1] != null)
                    Queue.AddLast(currentNode.children[1]);

                Queue.RemoveFirst();
            }






        }
    }
}
