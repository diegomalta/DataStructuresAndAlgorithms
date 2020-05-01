using System;
using System.Collections.Generic;

namespace MeetingScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* know the available time in two persons calendar
             * sample input:
             * Calendar-1 [[9:00,10:30],[12:00,13:00],[16:00,18:00]]
             * Dailybound [9:00,20:00]
             * 
             * Calendar-2 [[10:00,11:30],[12:30,14:30],[14:30,15:00],[16:00,17:00]]
             * Dailybound [10:00,18:30]
             * 
             * sample output: [[11:30,12:00],[15:00,16:00],[18:00,18:30]]
            */


            /*  merge both list
             *  [900,1130][1200,1430][1430,1500][1600,1800]
             *  
             *   
             */
            var list1 = new List<Tuple<int, int>>() {
                new Tuple<int, int>(900,1030),
                new Tuple<int, int>(1200,1300),
                new Tuple<int, int>(1600,1800),
            };
            var bound1 = new Tuple<int, int>(900, 2000);

            var list2 = new List<Tuple<int, int>>() {
                new Tuple<int, int>(1000,1130),
                new Tuple<int, int>(1230,1430),
                new Tuple<int, int>(1430,1500),
                new Tuple<int, int>(1600,1700),
            };
            var bound2 = new Tuple<int, int>(1000, 1830);

            var scheduler = new Scheduler(
                new Calendar(list1, bound1),
                new Calendar(list2, bound2));

            Console.WriteLine(string.Join(',', scheduler.GetAvailability()));
        }


    }
}
