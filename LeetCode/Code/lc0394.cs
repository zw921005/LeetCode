using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc394
    {
        public string DecodeString(string s)
        {
            var result = "";
            var stack = new Stack<char>();

            foreach (var c in s) {
                if (IsNum(c) && stack.Count > 0) {
                    result += new string(stack.ToArray());
                    stack.Clear();
                }
                else if (c != ']') {
                    stack.Push(c);
                }
                else {
                    var str = "";
                    while (stack.Peek() != '[') {
                        str = stack.Pop() + str;
                    }
                    stack.Pop();
                    var loop = Convert.ToInt32(stack.Pop());
                    for (int i = 0; i < loop; i++) {
                        result += str;
                    }
                }
            }
            if (stack.Count > 0) {
                result += new string(stack.ToArray());
                stack.Clear();
            }

            return result;
        }

        public bool IsNum(char c)
        {
            return new System.Text.RegularExpressions.Regex("[0-9]").IsMatch(c.ToString());
        }
    }
}
