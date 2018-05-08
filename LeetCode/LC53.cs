using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc53
    {
        static void Main(string[] args)
        {
        }

        public static int MaxSubArray(int[] nums)
        {
            if (nums.AsEnumerable().All(i => i < 0))
            {
                return nums.Max();
            }

            int maxSum = 0, sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum > maxSum)
                {
                    maxSum = sum;
                }
                else if (sum < 0)
                {
                    sum = 0;
                }
            }
            return maxSum;
        }
    }
}
