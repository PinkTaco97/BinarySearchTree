using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        public int value;
        public Node left = null;
        public Node right = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="val"></param>
        public Node(int val)
        {
            this.value = val;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        public void AddNode(Node node)
        {
            //If the new node's value is less than the current node's value
            if (node.value < this.value)
            {
                //If the left child is a leaf node
                if (this.left == null)
                {
                    this.left = node;
                }
                else
                {
                    this.left.AddNode(node);
                }
            }
            else if (node.value > this.value)
            {
                if(this.right == null)
                {
                    this.right = node;
                }
                else
                {
                    this.right.AddNode(node);
                }
            }
        }

        public void Visit()
        {
            if (this.left != null)
            {
                this.left.Visit();
            }

            Console.WriteLine(this.value);
            

            if (this.right != null)
            {
                this.right.Visit();
            }
        }

        public Node Search(int val)
        {
            if(this.value == val)
            {
                return this;
            }
            else if (val < this.value && this.left != null)
            {
                return this.left.Search(val);
            }
            else if (val > this.value && this.right != null)
            {
                return this.right.Search(val);
            }
            return null;
        }
    }
}
