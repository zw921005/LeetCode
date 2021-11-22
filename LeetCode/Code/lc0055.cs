using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc0055
    {
        public bool CanJump(int[] nums)
        {
            int max = 0;
            for (int i = 0; i <= max; i++)
            {
                max = Math.Max(max, i + nums[i]);
                if (max >= nums.Length - 1)
                    return true;
            }
            return false;
        }
    }
}
