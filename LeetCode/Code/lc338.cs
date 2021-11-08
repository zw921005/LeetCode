using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc338
    {
        public int[] CountBits(int n)
        {
            int[] ans = new int[n + 1];
            ans[0] = 0;
            if (n == 0) return ans;
            ans[1] = 1;

            int count = 2;
            int len = 2;
            while (count <= n)
            {
                for (int i = 0; i < len && i + len <= n; i++)
                {
                    ans[len + i] = ans[i] + 1;
                    count++;
                }
                len *= 2;
            }

            return ans;
        }
    }
}
