using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public interface TreeImp
    {
        void insertNode(int value);
        void removeNode( int value);

        Iterator getIterator();
        


    }
}
