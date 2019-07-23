using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        public int data;
        public int left;
        public int right;

        public Node(int nodeValue)
        {
            this.data = nodeValue;
            left = nodeValue;
            right = nodeValue;
        }
    }
}
