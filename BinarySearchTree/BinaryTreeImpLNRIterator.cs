using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class BinaryTreeImpLNRIterator : Iterator
    {
        private BinaryTreeNode _root;
  
        private List<int> _listValue;
        private int _currentValue;
        private int _currentNodeIndex;

        public BinaryTreeImpLNRIterator(BinaryTreeNode root)
        {
            this._root = root;
            _listValue = new List<int>();
            SortNodeList();
        }

        private void SortNodeList()
        {
            LNR(this._root);
        
        }

        private void LNR(BinaryTreeNode node)
        {
            if(node != null)
            {
                LNR((BinaryTreeNode)node.LeftNode);
                _listValue.Add(node.Value);
                LNR((BinaryTreeNode)node.RightNode);

            }
        }


        public void first()
        {
            this._currentValue = _listValue[0];
            this._currentNodeIndex = 0;
        }

        public void next()
        {
            _currentNodeIndex++;
            if (_currentNodeIndex >= _listValue.Count)
                _currentNodeIndex = _listValue.Count;
            this._currentValue = _listValue[_currentNodeIndex];
            
        }

        public bool isDone()
        {
            return _currentNodeIndex == _listValue.Count - 1;
        }

        public Node current()
        {
            return this._root.FindByValue(this._currentValue);
        }
    }
}
