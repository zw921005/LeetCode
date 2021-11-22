using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class lc0053
    {
        public int MaxSubArray(int[] nums)
        {
            int max = nums[0];
            int dp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                dp += nums[i];
                if (dp > max)
                {
                    max = dp;
                }
                if (dp < 0)
                {
                    dp = 0;
                }
            }

            return max;
        }
    }
}
