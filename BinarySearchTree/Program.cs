using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeImp BST = new BinaryTreeImp();
           
            BST.insertNode(13);
            BST.insertNode(5);
            BST.insertNode(66);
            BST.insertNode(9);
            BST.insertNode(17);
            BST.insertNode(20);

            Iterator ite = BST.getIterator();
            ite.first();
            Console.WriteLine(ite.current().Value);
            ite.next();
            Console.WriteLine(ite.current().Value);
            for (ite.first(); !ite.isDone(); ite.next())
            {
               Console.Write( ite.current().Value +" ");
            }

      
        }
    }
}
