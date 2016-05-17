using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Note<T>
    {
        protected T _data;

        public T Data
        {
            get { return _data; }
            set { _data = value; }
        }

        protected List<Note<T>> _neighbors;

        public List<Note<T>> Neighbors
        {
            get { return _neighbors; }
            set { _neighbors = value; }
        }

        public Note() { }

        public Note(T data) : this(data, null) { }

        public Note(T data, List<Note<T>> neighbors)
        {
            this._data = data;
            this._neighbors = neighbors;
        } 
        
    }
}
