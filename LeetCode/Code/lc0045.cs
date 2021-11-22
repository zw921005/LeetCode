using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc0045
    {
        public int Jump(int[] nums)
        {
            int[] dp = new int[nums.Length];
            for (int i = 1; i < nums.Length; i++)
            {
                dp[i] = nums.Length;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j <= i + nums[i] && j < nums.Length; j++)
                {
                    dp[j] = Math.Min(dp[i] + 1, dp[j]);
                }
            }

            return dp[dp.Length - 1];
        }
    }
}
