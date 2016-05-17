using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public interface TreeImp<T>
    {
        bool addNote(Note<T> newNote);
        bool removeNote(Note<T> note);
        bool removeNote(T data);
        int getHeight();
        int getDepth();
        


    }
}
