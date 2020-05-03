using System;

namespace PhoneNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * for given a numbers, [3,6,9]
             * return with the posibles words 
             * that we can create using the phone keys
             * --------------------
             * |  1  |  2  |  3  |
             * |     | abc | def |
             * -------------------
             * |  4  |  5  |  6  |
             * | ghi | jkl | mno |
             * -------------------
             * |  7  |  8  |  9  |
             * | pqr | suv | wxyz|
             * -------------------
             */

            var phoneNum = new PhoneNumbers();
            Console.WriteLine(string.Join(",",phoneNum.GetCombination(new int[] { 3, 6, 4 })));
        }
    }
}
