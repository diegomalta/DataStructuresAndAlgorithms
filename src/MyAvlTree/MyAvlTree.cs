using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAvlTree
{
    public class MyAvlTree
    {
        class Node
        {
            public int Value;
            public Node Left;
            public Node Right;
            public int Height;

            public Node(int value)
            {
                Value = value;
            }
        }

        private Node Root;

        public void Insert(int value)
        {
            Root = Insert(Root, value);
        }

        private Node Insert(Node root, int value)
        {
            if (root == null)
                return new Node(value);

            if (value > root.Value)
                root.Right = Insert(root.Right, value);
            else
                root.Left = Insert(root.Left, value);

            root.Height = Math.Max(NodeHeight(root.Left),
                                   NodeHeight(root.Right)) + 1;

            var balanceFactor = GetBalanceFactor(root);
            if (IsLeftHeavy(root))
                Console.WriteLine($"Left - Node: {root.Value} Factor: {balanceFactor}");
            else if (IsRightHeavy(root))
            {
                Console.WriteLine($"Right - Node: {root.Value} Factor: {balanceFactor}");
                balanceFactor = GetBalanceFactor(root.Right);
            }
                

            return root;
        }

        private bool IsLeftHeavy(Node root)
        {
            return GetBalanceFactor(root) > 1;
        }

        private bool IsRightHeavy(Node root)
        {
            return GetBalanceFactor(root) < -1;
        }

        private int GetBalanceFactor(Node root)
        {
            return root == null ? 0 : NodeHeight(root.Left) - NodeHeight(root.Right);
        }

        private int NodeHeight(Node node)
        {
            return node != null ? node.Height : -1;
        }
    }
}
