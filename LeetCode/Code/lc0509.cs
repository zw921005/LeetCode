using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc0509
    {
        public int Fib(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 0;
            if(n == 0)
                return dp[0];
            dp[1] = 1;
            if(n==1)
                return dp[1];

            for (int i = 2; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }
    }
}
