using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        protected int _value;

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        protected List<Node> _neighbors;

        public List<Node> Neighbors
        {
            get { return _neighbors; }
            set { _neighbors = value; }
        }

        public Node() { }

        public Node(int data) : this(data, null) { }

        public Node(int data, List<Node> neighbors)
        {
            this._value = data;
            this._neighbors = neighbors;
        }

        public virtual Node FindByValue(int value){return null;}
        
    }
}
