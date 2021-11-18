﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    internal class lc1137
    {
        public int Tribonacci(int n)
        {
            int[] dp = new int[n + 1];
            dp[0] = 0; if (n == 0) return 0;
            dp[1] = 1; if (n == 1) return 1;
            dp[2] = 1; if (n == 2) return 1;

            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 3] + dp[i - 2] + dp[i - 1];
            }

            return dp[n];
        }
    }
}
