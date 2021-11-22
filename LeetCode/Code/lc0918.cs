using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc0918
    {
        public int MaxSubarraySumCircular(int[] nums)
        {
            int max1 = nums[0];
            int dp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                dp += nums[i];
                if (dp > max1)
                {
                    max1 = dp;
                }
                if (dp < 0)
                {
                    dp = 0;
                }
            }

            int max2 = nums[0];
            int max2_index = 0;
            dp = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                dp += nums[i];
                if (dp > max2)
                {
                    max2 = dp;
                    max2_index = i;
                }
            }

            int max3 = nums[nums.Length - 1];
            int max3_index = nums.Length - 1;
            dp = 0;
            for (int i = nums.Length - 1; i > 0; i--)
            {
                dp += nums[i];
                if (dp > max3)
                {
                    max3 = dp;
                    max3_index = i;
                }
            }

            dp = 0;
            if (max2_index >= max3_index)
            {
                for (int i = max3_index; i <= max2_index; i++)
                {
                    dp += nums[i];
                }
            }

            int max_loop = max2 + max3 - dp;

            return Math.Max(max_loop, max1);
        }
    }
}
