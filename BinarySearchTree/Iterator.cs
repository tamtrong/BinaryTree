using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public interface Iterator<T>
    {
        void first();
        void next();
        bool isDone();
        Note<T> current();
    }
}
