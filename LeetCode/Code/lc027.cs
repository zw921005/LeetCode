using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc027
    {
        public void Test()
        {
            int[] nums = { 3, 2, 2, 3 };//[2,2]
            int result = RemoveElement(nums, 3);
            nums.Take(result).Print();
            nums = new[] { 1 };//[]
            result = RemoveElement(nums, 1);
            nums.Take(result).Print();
        }


        public int RemoveElement(int[] nums, int val)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }

            return j;
        }

        //public int RemoveElement(int[] nums, int val)
        //{
        //    int i = 0;
        //    int j = nums.Length - 1;
        //    while (i <= j)
        //    {
        //        if (nums[i] == val)
        //        {
        //            nums[i] = nums[j];
        //            j--;
        //        }
        //        else
        //        {
        //            i++;
        //        }
        //    }

        //    return j + 1;
        //}

        //public int RemoveElement(int[] nums, int val)
        //{
        //    if (nums.Length == 0) return 0;
        //    int j = nums.Length - 1;
        //    int i;
        //    for (i = 0; i <= j; i++)
        //    {
        //        while (nums[i] == val && i < j)
        //        {
        //            nums[i] = nums[j];
        //            j--;
        //        }
        //    }

        //    if (nums[i - 1] == val)
        //    {
        //        return i - 1;
        //    }
        //    else
        //    {
        //        return i;
        //    }

        //}
    }
}
