using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc020
    {
        public void Test()
        {
            string input = "()";//T
            Console.WriteLine(IsValid(input));
            input = "()[]{}";//T
            Console.WriteLine(IsValid(input));
            input = "(]";//F
            Console.WriteLine(IsValid(input));
            input = "([)]";//F
            Console.WriteLine(IsValid(input));
            input = "{[]}";//T
            Console.WriteLine(IsValid(input));
        }

        public bool IsValid(string s)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> dict = new Dictionary<char, char>() { { ')', '(' }, { ']', '[' }, { '}', '{' } };
            for (int i = 0; i < s.Length; i++)
            {
                if (stack.Count() == 0)
                {
                    stack.Push(s[i]);
                }
                else
                {
                    if (dict.ContainsKey(s[i]) && dict[s[i]] == stack.Peek())
                    {
                        stack.Pop();
                    }
                    else
                    {
                        stack.Push(s[i]);

                    }
                }
            }
            return stack.Count() == 0;
        }
    }
}
