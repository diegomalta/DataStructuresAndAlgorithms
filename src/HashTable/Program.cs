using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            HashTable ht = new HashTable();
            ht.Put(1, "a");
            ht.Put(2, "b");
            ht.Put(4, "c");
            ht.Put(5, "d");
            ht.Put(6, "e");
            ht.Put(7, "f");

            Console.WriteLine(ht.Get(4));

            ht.Remove(5);
            ht.Remove(10);
        }
    }
}
