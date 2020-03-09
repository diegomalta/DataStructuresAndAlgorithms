using System;

namespace Arrays
{
    public class MyArray
    {
        private readonly int incrementalFactor = 2;
        private int[] array;
        private int count;

        public MyArray(int length)
        {
            array = new int[length];
            count = 0;
        }

        public void Insert(int item)
        {            
            if (count == array.Length)
                Increase();
            array[count++] = item;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        private void Increase()
        {
            int[] newArray = new int[count * incrementalFactor];
            for(int i = 0; i < count; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
    }
}