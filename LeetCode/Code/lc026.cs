using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc026
    {
        public void Test()
        {

        }

        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;

            int index = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[index-1])
                {
                    if (i != index)
                    {
                        nums[index] = nums[i];
                    }
                    index++;
                }
            }

            return index;
        }
    }
}
