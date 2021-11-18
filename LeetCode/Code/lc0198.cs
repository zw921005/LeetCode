using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc0198
    {
        public void Test()
        {
            int[] nums = { 1, 2, 3, 1 };//4
            Console.WriteLine(Rob(nums));
            int[] nums1 = { 2, 7, 9, 3, 1 };//12
            Console.WriteLine(Rob(nums1));
        }

        public int Rob(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            int s0 = 0;
            int s1 = nums[0];
            int temp = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                temp = s1;
                s1 = s0 + nums[i];
                s0 = temp > s0 ? temp : s0;
            }

            return s1 > s0 ? s1 : s0;
        }
    }
}
