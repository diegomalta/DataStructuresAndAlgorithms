using System;
using System.Collections.Generic;

namespace FirstRepeatedCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * show the first char that is repeated in a sentence 
            */
            string input = "hi this is a text";
            Console.WriteLine(FirstRepeatedCharacter(input.ToCharArray()));
        }

        public static char FirstRepeatedCharacter(char[] expression)
        {
            var set = new HashSet<char>();

            foreach(var item in expression)
            {
                if (!set.Contains(item))
                {
                    set.Add(item);
                    continue;
                }

                return item;
            }

            return new char();
        }
    }
}
