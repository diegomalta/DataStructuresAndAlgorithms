using System;

namespace MyStackWithArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStackWithArray stack = new MyStackWithArray();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            stack.Push(6);
            stack.Push(7);
            stack.Push(8);
            stack.Push(9);
            stack.Push(10);
            stack.Push(11);

            Console.WriteLine(stack.IsEmpty());

            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            Console.WriteLine(stack.IsEmpty());

            stack.Pop();
        }
    }
}
