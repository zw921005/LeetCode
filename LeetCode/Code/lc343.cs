using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc343
    {
        public int IntegerBreak(int n)
        {
            if (n == 2) return 1;
            int x = 1;
            int y = 1;
            switch (n % 3) {
                case 0:
                    x = n / 3;
                    y = 1;
                    break;
                case 1:
                    x = n / 3 - 1;
                    y = 4;
                    break;
                case 2:
                    x = n / 3;
                    y = 2;
                    break;
            }

            return Convert.ToInt32(Math.Pow(3, x)) * y;
        }

        public int IntegerBreak1(int n)
        {
            int[] dp = new int[n + 1];

            for (int i = 2; i <= n; i++) {
                int curMax = 0;
                for (int j = 1; j < i; j++) {
                    curMax = Math.Max(curMax, Math.Max(j * (i - j), j * dp[i - j]));
                }
                dp[i] = curMax;
            }

            return dp[n];
        }
    }
}
