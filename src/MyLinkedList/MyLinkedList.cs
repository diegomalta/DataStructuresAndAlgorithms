
using System;

namespace MyLinkedList
{
    public class MyLinkedList
    {
        private class Node
        {
            public int Value;
            public Node Next;

            public Node(int value)
            {
                Value = value;
            }
        }

        private Node First;
        private Node Last;
        private int Size;

        public void AddLast(int value)
        {
            var node = new Node(value);

            if (First == null)
                First = Last = node;
            else
            {
                Last.Next = node;
                Last = node;
            }

            Size++;
        }

        public void AddFirst(int value)
        {
            var node = new Node(value);

            if (First == null)
                First = Last = node;
            else
            {
                node.Next = First;
                First = node;
            }

            Size++;
        }

        public int IndexOf(int value)
        {
            var item = First;
            var count = 0;

            while (item != null)
            {
                if (item.Value == value)
                    return count;
                item = item.Next;
                count++;
            }
            return -1;
        }

        public bool Contains(int value)
        {
            return IndexOf(value) != -1;
        }

        public void RemoveFirst()
        {
            if (First == null)
                return;

            if (First == Last)
            {
                First = Last = null;
                Size--;
            }
            else
            {
                var second = First.Next;
                First.Next = null;
                First = second;
            }

            Size--;
        }

        public void RemoveLast()
        {
            if (Last == null)
                return;

            if (First == Last)
                First = Last = null;
            else
            {
                var previous = GetPrevious(Last);
                Last = previous;
                Last.Next = null;
            }

            Size--;
        }

        public int GetSize()
        {
            return Size;
        }

        public int[] ToArray()
        {
            var array = new int[Size];

            var current = First;
            var index = 0;
            while (current != null)
            {
                array[index++] = current.Value;
                current = current.Next;
            }

            return array;
        }

        public void Reverse()
        {
            if (First == null)
                return;

            var previuos = First;
            var current = First.Next;
            while (current != null)
            {
                var next = current.Next;
                current.Next = previuos;
                previuos = current;
                current = next;
            }

            Last = First;
            Last.Next = null;
            First = previuos;
        }

        public int GetKthFromTheEnd(int k)
        {
            if (First == null)
                return -1;

            if (k > Size)
                return -1;

            var end = First;
            var kth = First;
            var distance = 0;
            while (end != Last)
            {
                end = end.Next;
                distance++;
                if (distance >= k)
                {
                    kth = kth.Next;
                }
            }

            return kth.Value;
        }

        public void PrintMiddle()
        {
            var a = First;
            var b = First;
            var count = 0;
            while (b != Last)
            {
                b = b.Next;
                count++;
                if (count==2)
                {
                    a = a.Next;
                    count = 0;
                }
            }

            if (count!=0)
            {
                Console.WriteLine($"{a.Value},{a.Next.Value}");
            }
            else
            {
                Console.WriteLine($"{a.Value}");
            }           
        }

        private Node GetPrevious(Node node)
        {
            var current = First;
            while (current != null)
            {
                if (current.Next == node)
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }
    }
}
