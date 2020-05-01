using System;
using System.Collections.Generic;

namespace MostPopulatedYear
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  1) sort the list in desc order 
             *  2) go through yearList and use a helperList to keep the active person count
             *  3) keeping a hashMap (year, count) with the numbers of active alive persons
             *  4) we need to remove the person once pass the way from helperList 
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
            yearCount.GetMostPopulatedYear(input);


        }
    }
}
