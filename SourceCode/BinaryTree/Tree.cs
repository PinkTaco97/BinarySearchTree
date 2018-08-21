using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// The Tree Class.
    /// </summary>
    class Tree
    {
        //The root of the tree.
        public Node root;

        /// <summary>
        /// Constructor.
        /// </summary>
        public Tree()
        {
            //Set the root to null.
            this.root = null;
        }

        /// <summary>
        /// Add a value to the tree.
        /// </summary>
        /// <param name="val"></param>
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
                //Try to add the new node to the root.
                this.root.AddNode(node);
            }
        }

        /// <summary>
        /// Traverse through the tree.
        /// </summary>
        public void Traverse()
        {
            //Traverse the root.
            root.Traverse();
        }

        /// <summary>
        /// Search through the tree.
        /// </summary>
        /// <param name="val">The value to search for.</param>
        /// <returns>The found node.</returns>
        public Node Search(int val)
        {
            //Start the search at the root.
            Node found = root.Search(val);

            //Return what we found.
            return found;
        }
    }
}
