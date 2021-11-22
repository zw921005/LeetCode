using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc0740
    {
        public int DeleteAndEarn(int[] nums)
        {
            if(nums.Length == 0) return 0;
            if(nums.Length==1) return nums[0]; 

            int max = nums.Max() + 1;
            int[] nums2 = new int[max];
            for (int i = 0; i < nums.Length; i++)
            {
                nums2[nums[i]] += nums[i];
            }

            return RobRange(nums2, 0, nums2.Length - 1);
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
