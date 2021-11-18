using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc494
    {
        private int count;
        public int FindTargetSumWays(int[] nums, int S)
        {
            calculate(nums, 0, 0, S);
            return count;
        }

        public void calculate(int[] nums,int i,int sum,int S)
        {
            if (nums.Length == i) {
                if (sum == S) {
                    count++;
                }
            }
            else {
                calculate(nums, i + 1, sum + nums[i], S);
                calculate(nums, i + 1, sum - nums[i], S);
            }
        }
    }
}
