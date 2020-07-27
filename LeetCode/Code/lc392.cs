using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc392
    {
        public bool IsSubsequence(string s, string t)
        {
            int p1 = 0; int p2 = 0;

            while (p1 < s.Length && p2 < t.Length) {
                if (s[p1] == t[p2]) {
                    p1++; p2++;
                }
                else {
                    p2++;
                }
            }

            return p1 == s.Length;
        }
    }
}
