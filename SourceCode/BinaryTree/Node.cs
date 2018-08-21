using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// The Node Class
    /// </summary>
    class Node
    {
        //The value the Node holds.
        public int value;
        
        //The Left Node.
        public Node left = null;

        //The Right Node.
        public Node right = null;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="value"></param>
        public Node(int value)
        {
            //Set the nodes value.
            this.value = value;
        }

        /// <summary>
        /// Try to add a node to the current node.
        /// </summary>
        /// <param name="node"></param>
        public void AddNode(Node node)
        {
            //If the new node's value is less than the current node's value.
            if (node.value < this.value)
            {
                //If the current node dosnt have a left node.
                if (this.left == null)
                {
                    //Set the child to the new node.
                    this.left = node;
                }
                else
                {
                    //Try to add the new node to the child.
                    this.left.AddNode(node);
                }
            }
            //If the new node's value is more than the current node's value.
            else if (node.value > this.value)
            {
                //If the current node dosnt have a right node.
                if(this.right == null)
                {
                    //Set the child to the new node.
                    this.right = node;
                }
                else
                {
                    //Try to add the new node to the child.
                    this.right.AddNode(node);
                }
            }
        }

        /// <summary>
        /// Traverse throughout the Tree.
        /// </summary>
        public void Traverse()
        {
            //If the current node has a left child.
            if (this.left != null)
            {
                //Traverse the left node.
                this.left.Traverse();
            }
            
            //Output the value of the node to the console.
            Console.Write(this.value + ",");
            
            //If the current node has a right child.
            if (this.right != null)
            {
                //Traverse the right node.
                this.right.Traverse();
            }
        }

        /// <summary>
        /// Searches the current node.
        /// </summary>
        /// <param name="val">The value to search for.</param>
        /// <returns>The found node.</returns>
        public Node Search(int val)
        {
            //If the current node's value == the value we are searching for.
            if(this.value == val)
            {
                //Return the current node.
                return this;
            }
            //If the value is less than the current node's value.
            else if (val < this.value && this.left != null)
            {
                //Search the current node's left child.
                return this.left.Search(val);
            }
            //If the value is more than the current node's value.
            else if (val > this.value && this.right != null)
            {
                //Search the current node's right child.
                return this.right.Search(val);
            }
            return null;
        }
    }
}
