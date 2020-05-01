using System;
using System.Collections.Generic;

namespace MeetingScheduler
{
    public class Calendar
    {
        public List<Tuple<int, int>> CalendarDay;
        public Tuple<int, int> DailyBound;
        public Calendar(List<Tuple<int, int>> calendarDay,
                       Tuple<int, int> dailyBound)
        {
            CalendarDay = calendarDay;
            DailyBound = dailyBound;
        }
    }

    public class Scheduler
    {
        private Calendar Cal1;
        private Calendar Cal2;

        public Scheduler(Calendar cal1, Calendar cal2)
        {
            Cal1 = cal1;
            Cal2 = cal2;
        }

        public List<Tuple<int, int>> GetAvailability()
        {
            var merged = MergeCalendars(Cal1.CalendarDay, Cal2.CalendarDay);
            return GetFreeTime(merged, Cal1.DailyBound, Cal2.DailyBound);
        }

        private List<Tuple<int, int>> MergeCalendars(List<Tuple<int, int>> cal1, List<Tuple<int, int>> cal2)
        {
            var mergedList = new List<Tuple<int, int>>();

            while (cal1.Count > 0 && cal2.Count > 0)
            {
                if (cal2.Count < 1)
                {
                    mergedList.Add(cal1[0]);
                    cal1.RemoveAt(0);
                }

                if (cal1.Count < 1)
                {
                    mergedList.Add(cal2[0]);
                    cal2.RemoveAt(0);
                }

                if (cal1[0].Item1 <= cal2[0].Item1)
                {
                    if (cal1[0].Item2 <= cal2[0].Item1)
                    {
                        mergedList.Add(cal1[0]);
                        cal1.RemoveAt(0);
                    }
                    else
                    {
                        mergedList.Add(new Tuple<int, int>(cal1[0].Item1,
                                                           cal1[0].Item2 > cal2[0].Item2 ? cal1[0].Item2 : cal2[0].Item2));
                        cal2.RemoveAt(0);
                        cal1.RemoveAt(0);
                    }
                }
                else
                {
                    if (cal2[0].Item2 <= cal1[0].Item1)
                    {
                        mergedList.Add(cal2[0]);
                        cal2.RemoveAt(0);
                    }
                    else
                    {
                        mergedList.Add(new Tuple<int, int>(cal2[0].Item1,
                                                          cal1[0].Item2 < cal2[0].Item2 ? cal2[0].Item2 : cal1[0].Item2));
                        cal1.RemoveAt(0);
                        cal2.RemoveAt(0);
                    }
                }
            }

            return mergedList;
        }

        private List<Tuple<int, int>> GetFreeTime(List<Tuple<int, int>> mergedCal, Tuple<int, int> bound1, Tuple<int, int> bound2)
        {
            var freeTime = new List<Tuple<int, int>>();

            // find free time between morning bound
            if (Math.Max(bound1.Item1, bound2.Item1) < mergedCal[0].Item1)
            {
                freeTime.Add(new Tuple<int, int>(Math.Max(bound1.Item1, bound2.Item1), mergedCal[0].Item1));
            }

            for (var i = 0; i < mergedCal.Count - 1; i++)
            {
                if (mergedCal[i].Item2 != mergedCal[i + 1].Item1)
                    freeTime.Add(new Tuple<int, int>(mergedCal[i].Item2, mergedCal[i + 1].Item1));
            }

            if (Math.Min(bound1.Item2, bound2.Item2) > mergedCal[mergedCal.Count - 1].Item2)
            {
                freeTime.Add(new Tuple<int, int>(mergedCal[mergedCal.Count - 1].Item2, Math.Min(bound1.Item2, bound2.Item2)));
            }

            return freeTime;
        }
    }
}
