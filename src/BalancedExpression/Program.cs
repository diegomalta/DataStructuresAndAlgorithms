using System;
using System.Collections.Generic;

namespace BalancedExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsBalanced(")"));
        }

        static bool IsBalanced(string expression)
        {
            var expressionArray = expression.ToCharArray();
            var leftBrackets = new List<char> { '(', '[', '{', '<' };
            var closeBrackets = new List<char> { ')', ']', ']', '>' };
            var stack = new Stack<char>();

            for (var i = 0; i < expressionArray.Length; i++)
            {
                if (leftBrackets.Contains(expressionArray[i]))
                {
                    stack.Push(expressionArray[i]);
                }
                else if (closeBrackets.Contains(expressionArray[i]))
                {
                    if (stack.Count <= 0)
                        return false;

                    if (closeBrackets.IndexOf(expressionArray[i]) != leftBrackets.IndexOf(stack.Pop()))
                    {
                        return false;
                    }
                }
            }

            if (stack.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
