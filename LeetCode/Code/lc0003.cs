using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc003
    {
        public int LengthOfLongestSubstring(string s)
        {
            int n = s.Length, ans = 0;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            for(int j = 0, i = 0; j < n; j++)
            {
                if (dict.ContainsKey(s[j]))
                {
                    i = Math.Max(dict[s[j]], i);
                }
                ans = Math.Max(ans, j - i + 1);
                dict[s[j]] = j + 1;
            }
            return ans;
        }
    }
}
