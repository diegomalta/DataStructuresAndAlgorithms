using System;

namespace MyStackWithArray
{
    public class MyStackWithArray
    {
        private int[] Array;
        private int Pointer;
        private const int InitialSize = 10;

        public MyStackWithArray()
        {
            Array = new int[InitialSize];
            Pointer = -1;
        }

        public void Push(int value)
        {
            if (!IsEnoughSpace())
                IncreaseArraySize();
            Array[++Pointer] = value;
        }

        public int Pop()
        {
            if (Pointer >= 0)
                return Array[Pointer--];
            else
                throw new Exception("empty stack");

        }

        public int Peek()
        {
            return Array[Pointer];
        }

        public bool IsEmpty()
        {
            return Pointer == -1 ? true : false;
        }

        private bool IsEnoughSpace()
        {
            return Array.Length == Pointer + 1 ? false : true; 
        }

        private void IncreaseArraySize()
        {
            var newArray = new int[Array.Length + InitialSize];
            for (int i = 0; i < Array.Length; i++)
                newArray[i] = Array[i];

            Array = newArray;
        }

    }
}
