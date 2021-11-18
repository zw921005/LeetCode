using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc300
    {
        public int LengthOfLIS(int[] nums)
        {
            int[] dp = new int[nums.Length];
            dp[0] = 1;
            int ans = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        dp[i] = Math.Max(dp[i], dp[j] + 1);
                    }
                }
                ans = Math.Max(ans, dp[i]);
            }
            return ans;
        }
    }
}
