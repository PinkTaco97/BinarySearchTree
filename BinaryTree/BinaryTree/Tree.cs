using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Tree
    {
        public Node root;

        /// <summary>
        /// Constructor
        /// </summary>
        public Tree()
        {
            this.root = null;
        }

        public void AddValue(int val)
        {
            //Create a new node.
            Node node = new Node(val);

            //If there is a root node.
            if(this.root == null)
            {
                //Set the new node as the root node.
                this.root = node;
            }
            else
            {
                this.root.AddNode(node);
            }
        }

        public void Traverse()
        {
            root.Visit();
        }

        public Node Search(int val)
        {
            Node found = root.Search(val);

            return found;
        }
    }
}
