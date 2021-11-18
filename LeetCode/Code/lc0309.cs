using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc309
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
                return 0;
            int n = prices.Length;

            int[][] dp = new int[n][];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = new int[3];
            }

            dp[0][0] = -prices[0];

            for (int i = 1; i < n; i++)
            {
                dp[i][0] = Math.Max(dp[i - 1][0], dp[i - 1][2] - prices[i]);
                dp[i][1] = dp[i - 1][0] + prices[i];
                dp[i][2] = Math.Max(dp[i - 1][2], dp[i - 1][1]);
            }

            return Math.Max(dp[n - 1][1], dp[n - 1][2]);
        }
    }
}
