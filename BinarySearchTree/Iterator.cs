using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public interface Iterator
    {
        void first();
        void next();
        bool isDone();
        Node current();
    }
}
