using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstNonRepeatedCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * find the first non repeated char
             **/

            string input = "an apple";
            Console.WriteLine(FindTheFirstNonRepeatedCharacter(input.ToCharArray()));
        }

        public static char FindTheFirstNonRepeatedCharacter(char[] expression)
        {
            var hashTable = new Dictionary<char,int>();

            // insert into the dictonary all the chars with the count
            foreach(var item in expression )
            {
                if(hashTable.ContainsKey(item))
                {
                    var count = hashTable.GetValueOrDefault(item);
                    hashTable[item] = ++count;                    
                }
                else
                {
                    hashTable.Add(item, 1);
                }
            }

            // find the first char with 1
            for(int i = 0;i < expression.Length; i++)
            {
                if (hashTable[expression[i]] == 1)
                {
                    return expression[i];
                }
            }

            //Console.WriteLine(string.Join(Environment.NewLine, hashTable.Select(a => $"{a.Key}: {a.Value}")));

            return new char();
        }
    }
}
