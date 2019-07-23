using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinaryTree
    {
        public int count = 0;
        public Node node;
        public Node newRoot;


        public void AddRoot(int nodeValue)
        {
            newRoot = new Node(nodeValue);
        }
        public void CreateChild(int nodeValue)
        {
            newRoot = new Node(nodeValue);
        }
        public void Add(int data)
        {


                if (newRoot == null)
                {
                    AddRoot(data);

                }
                else if (newRoot != null && newRoot.left != newRoot.data && newRoot.right != newRoot.data)
                {
                    CreateChild(data);
                }

                else if (data > newRoot.left)
                {
                    newRoot.left = data;
                }
                else if (data < newRoot.right)
                {
                    newRoot.right = data;

                }
                else
                {
                    Console.WriteLine("There was a mistake.");
                }
        }

        public int Search()
        {
            return 1;
        }

    }
}
