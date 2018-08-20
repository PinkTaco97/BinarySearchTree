using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree
    {
        Node root = null;

        /// <summary>
        /// Constructor
        /// </summary>
        public Tree()
        {

        }

        public void AddValue(int val)
        {
            Node node = new Node(val);
            if(this.root == null)
            {
                this.root = node;
            }
        }
    }
}
