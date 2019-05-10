using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc198
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

        //int[] cache = new int[1000];
        //bool flag = false;
        //public int Rob(int[] nums)
        //{
        //    int result;
        //    if (flag == false && nums.All(n => n == 0))
        //    {
        //        return 0;
        //    }
        //    flag = true;
        //    if (cache[nums.Length] != 0)
        //    {
        //        return cache[nums.Length];
        //    }
        //    else
        //    {
        //        if (nums.Length == 0)
        //        {
        //            result = 0;
        //        }
        //        else if (nums.Length == 1)
        //        {
        //            result = nums[0];
        //        }
        //        else if (nums.Length == 2)
        //        {
        //            result = Math.Max(nums[0], nums[1]);
        //        }
        //        else
        //        {
        //            int a = Rob(nums.Take(nums.Length - 2).ToArray()) + nums[nums.Length - 1];
        //            int b = Rob(nums.Take(nums.Length - 3).ToArray()) + nums[nums.Length - 2];
        //            result = Math.Max(a, b);
        //        }
        //        cache[nums.Length] = result;
        //    }

        //    return result;
        //}
    }
}
