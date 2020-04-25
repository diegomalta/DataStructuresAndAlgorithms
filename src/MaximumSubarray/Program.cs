using System;
using System.Linq;

namespace MaximumSubarray
{
    class Program
    {
        /*
        maximum array posible in sequence 
        [-2, 1, -3, 4, -1, 2, 1, -5, 4]   = [4, -1, 2, 1] = 6
                    *1
                              *2

        pivot = 5
        sum = 6
        *2
        */

        static void Main(string[] args)
        {
            var result = GetMaximumSubarray(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 });
            Console.WriteLine(string.Join(",", result));
        }

        static int[] GetMaximumSubarray(int[] array)
        {
            if (array.Length < 1)
                return null;

            var pivot = int.MinValue;
            var sum = 0;
            var firstPointer = 0;
            var secondPointer = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] > pivot + sum)
                {
                    pivot = array[i];                    
                    firstPointer = i;
                    if (secondPointer <= firstPointer)
                    {
                        secondPointer = firstPointer;
                        sum = array[i];
                        pivot = array[i];
                    }                        
                }
                else
                {
                    pivot += array[i];
                    if (pivot > sum)
                    {
                        secondPointer = i;
                        sum = pivot;
                    }
                }
            }

            return array.Skip(firstPointer).Take((secondPointer - firstPointer) + 1).ToArray();
        }        
    }
}
