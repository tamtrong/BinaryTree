using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTreeNode : Node
    {

        public BinaryTreeNode() { }

        public BinaryTreeNode(int data) : base(data, null) { }

        public BinaryTreeNode(int data, BinaryTreeNode left, BinaryTreeNode right)
        {
            this._value = data;
            this._neighbors = new  List<Node>(2) ;
            this._neighbors[0] = left;
            this._neighbors[1] = right;
        }

        public Node LeftNode
        {
            get 
            {
                if (_neighbors == null)
                    return null;
                return this._neighbors[0]; 
            }
            set 
            {
                if (_neighbors == null)
                    _neighbors = new List<Node>(2);
                this._neighbors[0] = value; 
            }
        }

        public Node RightNode
        {
            get
            {
                if (_neighbors == null)
                    return null;
                return this._neighbors[1];
            }
            set
            {
                if (_neighbors == null)
                    _neighbors = new List<Node>(2);
                this._neighbors[1] = value;
            }
        }

        public  Node FindByValue(int value)
        {
            BinaryTreeNode node = (BinaryTreeNode)this;
            while (node != null)
            {
                if (value.Equals(node.Value))
                {
                    return node;
                }
                if (value < node.Value)
                {
                    node = (BinaryTreeNode)node.LeftNode;
                }
                else
                {
                    node = (BinaryTreeNode)node.RightNode;

                }
            }
            return null;
        }
    }
}
