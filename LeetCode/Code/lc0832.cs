using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc832
    {
        public void Test()
        {
            int[][] input = { new[] { 1, 1, 0 }, new[] { 1, 0, 1 }, new[] { 0, 0, 0 } };
            FlipAndInvertImage(input).Print();
            input = new int[][] { new[] { 1, 1, 0, 0 }, new[] { 1, 0, 0, 1 }, new[] { 0, 1, 1, 1 }, new[] { 1, 0, 1, 0 } };
            FlipAndInvertImage(input).Print();
        }

        public int[][] FlipAndInvertImage(int[][] A)
        {
            foreach (int[] nums in A)
            {
                int looptime = nums.Length % 2 == 0 ? nums.Length / 2 - 1 : nums.Length / 2;
                for (int i = 0; i <= looptime; i++)
                {
                    int t = 1 - nums[i];
                    nums[i] = 1 - nums[nums.Length - i - 1];
                    nums[nums.Length - i - 1] = t;
                }
            }

            return A;
        }
    }
}
