using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 6, 2, 9, 4, 5 };
            BubbleSort(array);
            Console.WriteLine(string.Join(",", array));
        }

        static void BubbleSort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var isSorted = true;
                for (var j = 1; j < array.Length - i; j++)
                {
                    if (array[j - 1] > array[j])
                    {
                        var temp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = temp;
                        isSorted = false;
                    }
                }
                if (isSorted)
                    break;
            }
        }
    }
}
