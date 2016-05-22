using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTreeImp : TreeImp
    {
        private BinaryTreeNode _root;


        public void insertNode(int value)
        {
            _root = insert(_root, value);
        }
        
        private BinaryTreeNode insert (BinaryTreeNode root, int value)
        {
            if(root == null)
            {
                root = new BinaryTreeNode(value);
                return root;
            }

            if(value < root.Value)
            {
                root.LeftNode = insert((BinaryTreeNode)root.LeftNode, value);
            }

            else if(value > root.Value)
            {
                root.RightNode = insert((BinaryTreeNode)root.RightNode, value);
            }

            return root;
        }

        public void  removeNode(int value)
        {
            System.Console.WriteLine("Test!!");
        }


        public Iterator getIterator()
        {
            return new BinaryTreeImpLNRIterator(this._root);
        }
    }
}
