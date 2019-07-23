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
        List<int> treeArray = new List<int>();


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
            treeArray.Add(data);
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

        public void Search(int numberToSearch)
        {
            if (treeArray.Contains(numberToSearch))
            {
                Console.WriteLine(numberToSearch + " was found");
            }
            else
            {
                Console.WriteLine(numberToSearch + " was not found");
            }
        }

    }
}
