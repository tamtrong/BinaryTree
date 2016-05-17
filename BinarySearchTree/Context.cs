using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Context<T>
    {
        private TreeImp<T> _treeData;

        public TreeImp<T> TreeData
        {
            get { return _treeData; }
            set { _treeData = value; }
        }

        public Context(TreeImp<T> data)
        {
            this._treeData = data;
        }

       

        
    }
}
