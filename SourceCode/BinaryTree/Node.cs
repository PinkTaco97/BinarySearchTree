using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    /// <summary>
    /// The Int Node Class
    /// </summary>
    class NodeInt
    {
        //The value the Node holds.
        public int value;

        //The Left Node.
        public NodeInt left = null;

        //The Right Node.
        public NodeInt right = null;

        //The binary tree the node belongs to
        public BinaryTreeInt tree = null;

        /// <summary>
        /// Node that holds an int.
        /// </summary>
        /// <param name="value"></param>
        public NodeInt(BinaryTreeInt tree, int value)
        {
            //Set the nodes tree.
            this.tree = tree;

            //Set the nodes value.
            this.value = value;
        }

        /// <summary>
        /// Try to add a node to the current node.
        /// </summary>
        /// <param name="node"></param>
        public void AddNode(NodeInt node)
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

            //Add the current node to the sorted list.
            tree.sorted.Add(this);
            
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
        public NodeInt Search(int val)
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

    /// <summary>
    /// The String Node Class
    /// </summary>
    class NodeString
    {
        //The value the Node holds.
        public string value;

        //The Left Node.
        public NodeString left = null;

        //The Right Node.
        public NodeString right = null;

        //The binary tree the node belongs to
        public BinaryTreeString tree = null;

        /// <summary>
        /// Node that holds an int.
        /// </summary>
        /// <param name="value"></param>
        public NodeString(BinaryTreeString tree, string value)
        {
            //Set the nodes tree.
            this.tree = tree;

            //Set the nodes value.
            this.value = value;
        }

        /// <summary>
        /// Try to add a node to the current node.
        /// </summary>
        /// <param name="node"></param>
        public void AddNode(NodeString node)
        {
            //If the new node's value is less than the current node's value.
            if (String.Compare(node.value, this.value) < 0)
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
            else if (String.Compare(node.value, this.value) > 0)
            {
                //If the current node dosnt have a right node.
                if (this.right == null)
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

            //Add the current node to the sorted list.
            tree.sorted.Add(this);

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
        public NodeString Search(string val)
        {
            //If the current node's value == the value we are searching for.
            if (this.value == val)
            {
                //Return the current node.
                return this;
            }
            //If the value is less than the current node's value.
            else if (String.Compare(val, this.value) < 0 && this.left != null)
            {
                //Search the current node's left child.
                return this.left.Search(val);
            }
            //If the value is more than the current node's value.
            else if (String.Compare(val, this.value) > 0 && this.right != null)
            {
                //Search the current node's right child.
                return this.right.Search(val);
            }
            return null;
        }
    }
}
