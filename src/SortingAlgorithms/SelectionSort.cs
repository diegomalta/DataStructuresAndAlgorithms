using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class SelectionSort
    {

        public void Sort(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var indexToSwap = GetMinIndex(array, array[i], i);
                if (indexToSwap != i)
                {
                    var helper = array[i];
                    array[i] = array[indexToSwap];
                    array[indexToSwap] = helper;
                }
            }
        }

        private int GetMinIndex(int[] array, int value, int indexStart)
        {
            var min = value;
            var index = indexStart;
            for (var i = indexStart + 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }                    
            }

            return index;
        }
        
    }
}
