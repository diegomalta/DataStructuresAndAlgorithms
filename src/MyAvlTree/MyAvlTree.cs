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
            {
                Console.WriteLine($"Left - Node: {root.Value} Factor: {balanceFactor}");
                if (GetBalanceFactor(root.Left) > 0)
                {
                    Console.WriteLine($"we need to do a Right Rotation: {GetBalanceFactor(root.Left)}");
                }
                else
                {
                    Console.WriteLine($"we need to do a Left-Right Rotation: {GetBalanceFactor(root.Left)}");
                }
            }                
            else if (IsRightHeavy(root))
            {
                Console.WriteLine($"Right - Node: {root.Value} Factor: {balanceFactor}");
                if(GetBalanceFactor(root.Right) > 0)
                {
                    Console.WriteLine($"We need to do a Right-Left Rotation : {GetBalanceFactor(root.Right)}");
                }
                else
                {
                    Console.WriteLine($"We need to do a Left Rotation : {GetBalanceFactor(root.Right)}");
                }
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
