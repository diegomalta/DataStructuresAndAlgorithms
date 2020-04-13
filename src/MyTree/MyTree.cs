using System;
using System.Collections.Generic;
using System.Linq;

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

        #region Add
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
        #endregion

        #region Find
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
        #endregion

        #region Pre-Order
        public void PrintPreOrder()
        {
            PrintPreOrder(Root);
        }

        private void PrintPreOrder(Node root)
        {
            if (root == null)
                return;

            Console.WriteLine(root.Value);

            PrintPreOrder(root.Left);
            PrintPreOrder(root.Rigth);
        }
        #endregion

        #region In-Order        
        public void PrintInOrder()
        {
            PrintInOrder(Root);
        }

        private void PrintInOrder(Node root)
        {
            if (root == null)
                return;

            PrintInOrder(root.Left);
            Console.WriteLine(root.Value);
            PrintInOrder(root.Rigth);
        }
        #endregion

        #region Post-Order        
        public void PrintPostOrder()
        {
            PrintPostOrder(Root);
        }

        private void PrintPostOrder(Node root)
        {
            if (root == null)
                return;

            PrintPostOrder(root.Left);
            PrintPostOrder(root.Rigth);
            Console.WriteLine(root.Value);
        }
        #endregion

        #region Tree-Height        
        public int Height()
        {
            return Height(Root);
        }

        private int Height(Node root)
        {
            if (root == null)
                return int.MinValue;

            if (root.Rigth == null && root.Left == null)
                return 0;

            return Math.Max(Height(root.Left), Height(root.Rigth)) + 1;
        }

        #endregion

        #region Min-value
        public int Min()
        {
            return Min(Root);
        }

        private int Min(Node root)
        {
            if (root == null)
                return int.MaxValue;

            if (root.Left == null && root.Rigth == null)
                return root.Value;

            var left = Min(root.Left);
            var right = Min(root.Rigth);
            return Math.Min(Math.Min(left, right), root.Value);
        }
        #endregion

        #region AreEquals
        public bool AreEquals(MyTree other)
        {
            if (other == null)
                return false;

            return AreEquals(Root, other.Root);
        }

        private bool AreEquals(Node first, Node second)
        {
            if (first == null && second == null)
                return true;

            if (first != null && second != null)
                return first.Value == second.Value &&
                        AreEquals(first.Left, second.Left) &&
                        AreEquals(first.Rigth, second.Rigth);

            return false;
        }

        #endregion

        #region ValidateBST
        public bool ValidateBST()
        {
            return ValidateBST(Root, int.MinValue, int.MaxValue);
        }
        private bool ValidateBST(Node node, int lower, int upper)
        {
            if (node == null)
                return true;

            if (node.Value <= lower || node.Value >= upper)
                return false;

            return ValidateBST(node.Left, lower, node.Value) && ValidateBST(node.Rigth, node.Value, upper);
        }
        #endregion

        #region PrintNodeAtKLevel
        public void PrintNodeAtKLevel(int k)
        {
            PrintNodeAtKLevel(Root, 0, k);
        }

        private void PrintNodeAtKLevel(Node root, int level, int k)
        {
            if (root == null)
                return;

            if (k == level)
            {
                Console.WriteLine(root.Value);
                return;
            }

            PrintNodeAtKLevel(root.Left, level + 1, k);
            PrintNodeAtKLevel(root.Rigth, level + 1, k);
        }
        #endregion

        #region Avg-at-level

        public void PrintAvgPerLevel()
        {
            var dic = new Dictionary<int, List<int>>();
            CollectValues(Root, 0, dic);

            foreach (var item in dic)
            {
                var list = item.Value;
                var total = list.Sum() / list.Count;
                Console.WriteLine($"Level: {item.Key} Avg: {total}");
            }
        }

        private void CollectValues(Node root, int level, Dictionary<int , List<int>> dic)
        {
            if (root == null)
                return;
            
            if (dic.GetValueOrDefault(level) == null)
            {
                dic[level] = new List<int> { root.Value };
            }
            else
            {
                var list = dic[level];
                list.Add(root.Value);
                dic[level] = list;
            }

            CollectValues(root.Left, level + 1, dic);
            CollectValues(root.Rigth, level + 1, dic);
        }

        #endregion
    }
}