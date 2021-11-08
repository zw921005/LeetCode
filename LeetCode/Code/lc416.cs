using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc416
    {
        public bool canPartition1(int[] nums)
        {
            int n = nums.Length;
            if (n < 2)
            {
                return false;
            }
            int sum = 0, maxNum = 0;
            foreach (int num in nums)
            {
                sum += num;
                maxNum = Math.Max(maxNum, num);
            }
            if (sum % 2 != 0)
            {
                return false;
            }
            int target = sum / 2;
            if (maxNum > target)
            {
                return false;
            }
            bool[] dp = new bool[target + 1];
            dp[0] = true;
            for (int i = 0; i < n; i++)
            {
                int num = nums[i];
                for (int j = target; j >= num; --j)
                {
                    dp[j] |= dp[j - num];
                }
            }
            return dp[target];
        }

        public bool CanPartition(int[] nums)
        {
            int sum = nums.Sum();
            if (sum % 2 == 1) return false;
            sum /= 2;
            var dp = new HashSet<int>();
            var list = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == sum)
                {
                    return true;
                }
                else if (nums[i] > sum)
                {
                    return false;
                }

                foreach (var item in dp)
                {
                    var itemSum = item + nums[i];
                    if (!dp.Contains(itemSum))
                    {
                        if (itemSum == sum)
                        {
                            return true;
                        }
                        else if (itemSum < sum)
                        {
                            list.Add(itemSum);
                        }
                    }
                }
                foreach (var item in list)
                {
                    dp.Add(item);
                }
                dp.Add(nums[i]);
            }
            return false;
        }
    }
}
