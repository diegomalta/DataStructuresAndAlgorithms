using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    public class MyTree
    {
        public class Node
        {
            public int Value { get; set; }
            public Node Rigth { get; set; }
            public Node Left { get; set; }

            public Node(int value)
            {
                Value = value;
            }
        }

        private Node Root;

        public void Add(int value)
        {
            var newNode = new Node(value);
            if (Root == null)
            {
                Root = newNode;
                return;
            }

            var current = Root;
            while (true)
            {
                if (current.Value > value)
                {
                    if (current.Left == null)
                    {
                        current.Left = newNode;
                        break;
                    }
                    current = current.Left;
                }
                else
                {
                    if (current.Rigth == null)
                    {
                        current.Rigth = newNode;
                        break;
                    }
                    current = current.Rigth;
                }
            }
        }

        public bool Find(int value)
        {
            return Find(Root, value);
        }

        private bool Find(Node node, int value)
        {
            if (node == null)
                return false;
            if (node.Value == value)
                return true;

            if (value > node.Value)
                return Find(node.Rigth, value);
            else
                return Find(node.Left, value);
        }

        public void PrintPreOrder()
        {
            PrintPreOrder(Root);
        }

        private void PrintPreOrder (Node root)
        {
            if (root == null)
                return;

            Console.WriteLine(root.Value);

            PrintPreOrder(root.Left);
            PrintPreOrder(root.Rigth);
        }

        public void PrintInOrder()
        {
            PrintInOrder(Root);
        }

        private void PrintInOrder (Node root)
        {
            if (root == null)
                return;

            PrintInOrder(root.Left);
            Console.WriteLine(root.Value);
            PrintInOrder(root.Rigth);
        }
    }
}