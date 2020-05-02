using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostPopulatedYear
{
    public class MostPopulatedYear
    {
        private SortedDictionary<int, int> HashYears;

        public MostPopulatedYear()
        {
            HashYears = new SortedDictionary<int, int>();
        }

        // will return the most populated year with the count 
        public int GetMostPopulatedYear(List<Tuple<int, int>> personList)
        {
            Console.WriteLine("Initial " + string.Join(',', personList));
            FeedHashList(personList);

            Console.WriteLine(string.Join(",", personList));
            Console.WriteLine(string.Join(",", HashYears));

            var result = GetResultList();
            Console.WriteLine(string.Join(",", result));

            return result.Max(x => x.Item2);
        }

        private void FeedHashList(List<Tuple<int, int>> personList)
        {
            foreach (var person in personList)
            {
                if (!HashYears.ContainsKey(person.Item1))
                    HashYears.Add(person.Item1, 1);
                else
                {
                    var value = HashYears[person.Item1];
                    HashYears[person.Item1] = ++value;
                }

                if (!HashYears.ContainsKey(person.Item2))
                    HashYears.Add(person.Item2, -1);
                else
                {
                    var value = HashYears[person.Item2];
                    HashYears[person.Item2] = --value;
                }
            }
        }

        private List<Tuple<int, int>> GetResultList()
        {
            var count = 0;
            var result = new List<Tuple<int, int>>();
            foreach (var year in HashYears)
            {
                result.Add(new Tuple<int, int>(year.Key, year.Value + count));
                count = count + year.Value;
            }

            return result;
        }
    }
}
