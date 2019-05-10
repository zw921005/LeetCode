using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc303
    {
        public void Test()
        {
            int[] nums = { -2, 0, 3, -5, 2, -1 };
            NumArray(nums);
            Console.WriteLine(SumRange(0, 2));
            Console.WriteLine(SumRange(2, 5));
            Console.WriteLine(SumRange(0, 5));
        }
        int[] cache;
        public void NumArray(int[] nums)
        {
            cache = new int[nums.Length + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                cache[i + 1] = cache[i] + nums[i];
            }
        }

        public int SumRange(int i, int j)
        {
            return cache[j + 1] - cache[i];
        }

        //public int SumRange(int i, int j)
        //{
        //    int sum = 0;
        //    for (; i <= j; i++)
        //    {
        //        sum += nums[i];
        //    }
        //    return sum;
        //}
    }
}
