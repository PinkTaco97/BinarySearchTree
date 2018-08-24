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
    class BinaryTreeInt
    {
        //The root of the tree.
        public NodeInt root;

        //List of values that the tree holds.
        public List<NodeInt> sorted = new List<NodeInt>();

        /// <summary>
        /// Constructor.
        /// </summary>
        public BinaryTreeInt()
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
            NodeInt node = new NodeInt(this, val);

            //If there isnt a root node.
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
            //Clear the list.
            sorted.Clear();

            //Traverse the root.
            root.Traverse();
        }

        /// <summary>
        /// Search through the tree.
        /// </summary>
        /// <param name="val">The value to search for.</param>
        /// <returns>The found node.</returns>
        public NodeInt Search(int val)
        {
            //Start the search at the root.
            NodeInt found = root.Search(val);

            //Return what we found.
            return found;
        }

        /// <summary>
        /// Print the sorted list to the console.
        /// </summary>
        public void Print()
        {
            //Go through each node in the sorted array.
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.Write(sorted[i].value + ",");
            }
        }
    }

    /// <summary>
    /// The Tree Class.
    /// </summary>
    class BinaryTreeString
    {
        //The root of the tree.
        public NodeString root;

        //List of values that the tree holds.
        public List<NodeString> sorted = new List<NodeString>();

        /// <summary>
        /// Constructor.
        /// </summary>
        public BinaryTreeString()
        {
            //Set the root to null.
            this.root = null;
        }

        /// <summary>
        /// Add a value to the tree.
        /// </summary>
        /// <param name="val"></param>
        public void AddValue(string val)
        {
            //Create a new node.
            NodeString node = new NodeString(this, val);

            //If there isnt a root node.
            if (this.root == null)
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
            //Clear the list.
            sorted.Clear();

            //Traverse the root.
            root.Traverse();
        }

        /// <summary>
        /// Search through the tree.
        /// </summary>
        /// <param name="val">The value to search for.</param>
        /// <returns>The found node.</returns>
        public NodeString Search(string val)
        {
            //Start the search at the root.
            NodeString found = root.Search(val);

            //Return what we found.
            return found;
        }

        /// <summary>
        /// Print the sorted list to the console.
        /// </summary>
        public void Print()
        {
            //Go through each node in the sorted array.
            for (int i = 0; i < sorted.Count; i++)
            {
                Console.Write(sorted[i].value + ",");
            }
        }
    }
}
