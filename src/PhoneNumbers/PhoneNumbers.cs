using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneNumbers
{
    public class PhoneNumbers
    {
        private Dictionary<int, char[]> phoneKeys;

        public PhoneNumbers()
        {
            phoneKeys = new Dictionary<int, char[]>();
            phoneKeys.Add(1, new char[] { } );
            phoneKeys.Add(2, new char[] { 'a','b','c' });
            phoneKeys.Add(3, new char[] { 'd', 'e', 'f' });
            phoneKeys.Add(4, new char[] { 'g', 'h', 'i' });
            phoneKeys.Add(5, new char[] { 'j', 'k', 'l' });
            phoneKeys.Add(6, new char[] { 'm', 'n', 'o' });
            phoneKeys.Add(7, new char[] { 'p', 'q', 'r' });
            phoneKeys.Add(8, new char[] { 's', 'u', 'v' });
            phoneKeys.Add(9, new char[] { 'w', 'x', 'y', 'z' });

            
        }

        public List<string> GetCombination(int[] digits)
        {
            var words = new List<string>();
            GetCombinatorHelper(digits, "", words);
            return words;
        }

        private void GetCombinatorHelper(int[] digits, string letters, List<string> words)
        {
            if (digits.Length == 0)
            {
                words.Add(string.Join("", letters));
                return;
            }

            var charkeys = phoneKeys[digits[0]];
            foreach (var charKey in charkeys)
            {
                GetCombinatorHelper(digits.Skip(1).ToArray(), letters + charKey, words);
            }

        }
    }
}
