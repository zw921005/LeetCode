using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc322
    {
        public int CoinChange(int[] coins, int amount)
        {
            int[] dp = new int[amount + 1];
            dp[0] = 0;

            for (int i = 1; i <= amount; i++)
            {
                int min = -1;
                foreach (var coin in coins)
                {
                    if (i - coin >= 0)
                    {
                        if (dp[i - coin] != -1)
                        {
                            if (min != -1)
                            {
                                min = Math.Min(min, dp[i - coin] + 1);
                            }
                            else
                            {
                                min = dp[i - coin] + 1;
                            }
                        }
                    }
                }
                dp[i] = min;
            }

            return dp[amount];
        }
    }
}
