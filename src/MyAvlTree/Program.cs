using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAvlTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var avlTree = new MyAvlTree();
            //avlTree.Insert(10);
            //avlTree.Insert(30);
            //avlTree.Insert(20);

            //avlTree.Insert(10);
            //avlTree.Insert(5);
            //avlTree.Insert(4);


            var hs = new SortedSet<int>();
            hs.Add(2);
            hs.Add(5);
            hs.Add(9);
            hs.Add(9);
            Console.WriteLine(hs.Max);
            
        }
    }
}
