using System;
using System.Collections.Generic;

namespace MostPopulatedYear
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             *   Build a sorted Hash table to save the year and the count
             *   1950 | 1
             *   1803 | 2
             *   1870 | -1
             *   1922 | -1
             *   
             *   then updat the count of that hash table and get the max
             *     
             */

            var input = new List<Tuple<int, int>>();
            input.Add(new Tuple<int, int>(2000, 2010));
            input.Add(new Tuple<int, int>(1975, 2005));
            input.Add(new Tuple<int, int>(1975, 2003));
            input.Add(new Tuple<int, int>(1803, 1809));
            input.Add(new Tuple<int, int>(1750, 1869));
            input.Add(new Tuple<int, int>(1840, 1935));
            input.Add(new Tuple<int, int>(1803, 1921));
            input.Add(new Tuple<int, int>(1894, 1921));

            var yearCount = new MostPopulatedYear();
            Console.WriteLine(yearCount.GetMostPopulatedYear(input));


        }
    }
}
