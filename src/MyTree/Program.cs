using System;
using System.Collections;

namespace MyTree
{
    class Program
    {
        static void Main(string[] args)
        {
            var tree = new MyTree();
            tree.Add(7);
            tree.Add(4);
            tree.Add(9);
            tree.Add(1);
            tree.Add(6);
            tree.Add(8);
            tree.Add(10);

            //tree.PrintPreOrder();
            tree.PrintInOrder();
        }
    }
}
