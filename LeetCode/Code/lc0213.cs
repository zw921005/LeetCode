using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc0213
    {
        public int Rob(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            else if (nums.Length == 2)
                return Math.Max(nums[0], nums[1]);
            else
            {
                return Math.Max(RobRange(nums, 0, nums.Length - 2), RobRange(nums, 1, nums.Length - 1));
            }
        }

        public int RobRange(int[] nums, int start, int end)
        {
            int first = nums[start];
            int second = Math.Max(nums[start], nums[start + 1]);

            for (int i = start + 2; i <= end; i++)
            {
                int temp = second;
                second = Math.Max(nums[i] + first, second);
                first = temp;
            }

            return second;
        }
    }
}
