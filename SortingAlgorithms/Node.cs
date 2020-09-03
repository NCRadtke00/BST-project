using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Node
    {
        public int Data;
        public Node left { get; set; }
        public Node right { get; set; }
        public Node(int data)
        {
            this.Data = data;
        }
    }
}
