using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * An array that inclement its length automatically
             **/
            MyArray array = new MyArray(3);
            array.Insert(10);
            array.Insert(11);
            array.Insert(12);
            array.Insert(13);
            array.Insert(14);
            array.Print();
        }
    }
}
