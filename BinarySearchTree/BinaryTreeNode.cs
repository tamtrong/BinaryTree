using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTreeNode<T> : Note<T> 
    {

        public BinaryTreeNode() { }

        public BinaryTreeNode(T data) : base(data, null) { }

        public BinaryTreeNode(T data, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
        {
            this._data = data;
            this._neighbors = new List<Note<T>>(2);
            this._neighbors[0] = left;
            this._neighbors[1] = right;
        }

        public Note<T> LeftNote
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
                    _neighbors = new List<Note<T>>(2);
                this._neighbors[0] = value; 
            }
        }

        public Note<T> RightNote
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
                    _neighbors = new List<Note<T>>(2);
                this._neighbors[1] = value;
            }
        }
    }
}
