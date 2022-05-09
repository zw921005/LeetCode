using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc0942
    {
        public int[] DiStringMatch(string s)
        {
            var result = new int[s.Length + 1];
            result[0] = 0;
            var i = 1;
            var top = 0; var bottom = 0;
            foreach (char c in s)
            {
                if (c == 'I')
                {
                    result[i++] = ++top;
                }
                else if (c == 'D')
                {
                    result[i++] = --bottom;
                }
            }

            for (int j = 0; j < result.Length; j++)
            {
                result[j] -= bottom;
            }
            
            return result;
        }
    }
}
