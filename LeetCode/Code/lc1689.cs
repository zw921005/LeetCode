using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc1689
    {
        public int FindMagicIndex(int[] nums)
        {
            for(int i = 0; i < nums.Length; i++) {
                if (nums[i] == i)
                    return i;
            }

            return -1;
        }
    }
}
