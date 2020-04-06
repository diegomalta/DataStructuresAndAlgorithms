using System;
using System.Collections.Generic;

namespace MyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new MyLinkedList();
            linkedList.AddLast(10);
            linkedList.AddLast(20);
            linkedList.AddLast(30);
            linkedList.AddFirst(5);
            linkedList.AddFirst(1);

            Console.WriteLine(linkedList.IndexOf(30));
            Console.WriteLine(linkedList.Contains(1));
            Console.WriteLine(linkedList.GetSize());

            Console.WriteLine(linkedList.GetSize());
            Console.WriteLine(String.Join(',', linkedList.ToArray()));
            linkedList.Reverse();
            Console.WriteLine(String.Join(',', linkedList.ToArray()));
            Console.WriteLine(linkedList.GetKthFromTheEnd(3));
            
            linkedList.PrintMiddle();
        }
    }
}
