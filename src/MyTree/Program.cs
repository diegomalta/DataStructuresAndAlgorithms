using System;
using System.Collections;

namespace MyTree
{
    class Program
    {
        static void Main(string[] args)
        {

/*
              7
           /    \
          4      9
         / \    /  \
        1   6  8   10

4
*/


            var tree = new MyTree();
            tree.Add(7);
            tree.Add(4);
            tree.Add(9);
            tree.Add(1);
            tree.Add(6);
            tree.Add(8);
            tree.Add(10);


            var tree2 = new MyTree();
            tree2.Add(7);
            tree2.Add(4);
            tree2.Add(9);
            tree2.Add(1);
            tree2.Add(6);
            tree2.Add(8);
            tree2.Add(10);

            //tree.PrintPreOrder();
            //tree.PrintInOrder();
            //tree.PrintPostOrder();
            // Console.WriteLine(tree.Height());
            // Console.WriteLine(tree.Min());
            // Console.WriteLine(tree.AreEquals(tree2));
            Console.WriteLine(tree.ValidateBST());
            
        }
    }
}
