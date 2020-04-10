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

        public MyTree()
        {
        }

        public void Add(int value)
        {
            var newNode = new Node(value);
            if(Root == null)
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

        public bool Find (int value)
        {
            return true;
        }
    }
}