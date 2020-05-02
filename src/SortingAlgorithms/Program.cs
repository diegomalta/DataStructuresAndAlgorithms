﻿using System;
using System.Collections.Generic;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 6, 2, 9, 4, 5 };
            var bubbleSort = new BubbleSort();
            var selectionSort = new SelectionSort();

            Console.WriteLine("NoSorted: " + string.Join(",", array));
            //bubbleSort.Sort(array);
            selectionSort.Sort(array);
            Console.WriteLine("Sorted: " + string.Join(",", array));
        }

    }
}
