using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc496
    {
        public void Test()
        {
            int[] findNums = { 4, 1, 2 };//[-1,3,-1]
            int[] nums = { 1, 3, 4, 2 };
            NextGreaterElement(findNums, nums).Print();
            findNums = new int[] { 1, 3, 5, 2, 4 };//[7,7,7,7,7]
            nums = new int[] { 6, 5, 4, 3, 2, 1, 7 };
            NextGreaterElement(findNums, nums).Print();
        }

        public int[] NextGreaterElement(int[] findNums, int[] nums)
        {
            int[] res = new int[findNums.Length];
            Dictionary<int, int> dict = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();

            foreach (int num in nums)
            {
                while (stack.Count() != 0 && num > stack.Peek())
                {
                    dict.Add(stack.Pop(), num);
                }
                stack.Push(num);
            }

            for (int i = 0; i < findNums.Length; i++)
            {
                res[i] = dict.ContainsKey(findNums[i]) ? dict[findNums[i]] : -1;
            }

            return res;
        }

        //public int[] NextGreaterElement(int[] findNums, int[] nums)
        //{
        //    int[] res = new int[findNums.Length];

        //    for (int i = 0; i < findNums.Length; i++)
        //    {
        //        for (int j = 0; j < nums.Length; j++)
        //        {
        //            if (nums[j] == findNums[i])
        //            {
        //                for (int k = j + 1; k < nums.Length; k++)
        //                {
        //                    if (nums[k] > nums[j])
        //                    {
        //                        res[i] = nums[k];
        //                        break;
        //                    }
        //                }
        //                break;
        //            }
        //        }
        //        if (res[i] == 0)
        //        {
        //            res[i] = -1;
        //        }
        //    }

        //    return res;
        //}
    }
}
