using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        int value;
        Node left = null;
        Node right = null;

        public Node(int val)
        {
            this.value = val;
        }
    }
}
