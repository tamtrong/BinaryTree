using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Context
    {
        private TreeImp _treeData;

        public TreeImp TreeData
        {
            get { return _treeData; }
            set { _treeData = value; }
        }

        public Context(TreeImp data)
        {
            this._treeData = data;
        }

       

        
    }
}
