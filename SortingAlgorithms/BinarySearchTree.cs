using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class BinarySearchTree
    {
        public Node Root { get; set; }
        public void Add(int d)
        {
            if (this.Root == null)
            {
                this.Root = new Node(d);
            }
            else
            {
                Node currentNode = this.Root;
                while (currentNode != null)
                {
                    if(d <= currentNode.Data)
                    {
                        currentNode = currentNode.left;
                    }
                    else if (d > currentNode.Data)
                    {
                        currentNode = currentNode.right;
                    }
                }
                currentNode = new Node(d);
            }

        }
        public Node Search(int d)
        {
            return this.Search(d, this.Root);
        }
        private Node Search(int d, Node currentNode)
        {
            if (currentNode != null)
            {
                if (d == currentNode.Data)
                {
                    return currentNode;
                }
                else if (d <= currentNode.Data)
                {
                    return Search(d, currentNode.left);
                }
                else if (d > currentNode.Data)
                {
                    return Search(d, currentNode.right);
                }
            }
            return null;
        }
    }
}