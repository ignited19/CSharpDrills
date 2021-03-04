using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_Drills
{
    public class Node
    {
        public string id;
        public  Node[] children = new Node[2];

        public Node(string id)
        {
            this.id = id;

        }

        public void addChildren(Node left, Node right)
        {
            children[0] = left;
            children[1] = right;
        }

    }
}
