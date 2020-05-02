using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class BubbleSort
    {
        public void Sort(int[] array)
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
