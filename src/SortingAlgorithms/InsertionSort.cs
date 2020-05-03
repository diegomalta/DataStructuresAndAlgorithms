using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class InsertionSort
    {
        public void Sort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                InsertItem(array, array[i], i);
            }
        }

        private void InsertItem(int[] array, int value, int bound)
        {
            var i = bound;
            var index = -1;
            while (i > 0 && value < array[i - 1])
            {
                array[i] = array[i - 1];
                index = i - 1;
                i--;
            }               
            if (index >= 0)
                array[index] = value;
        }
    }
}
