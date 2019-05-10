using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc169
    {
        public void Test()
        {
            int[] input = { 3, 2, 3 };//3
            Console.WriteLine(MajorityElement(input));
            input = new int[] { 2, 2, 1, 1, 1, 2, 2 };//2
            Console.WriteLine(MajorityElement(input));
        }

        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]) == false)
                {
                    dict.Add(nums[i], 1);
                }
                else
                {
                    dict[nums[i]]++;
                }
            }

            KeyValuePair<int, int>? entry = null;
            foreach (KeyValuePair<int, int> pair in dict)
            {
                if (entry == null || pair.Value > entry.Value.Value)
                {
                    entry = pair;
                }
            }

            return entry.Value.Key;
        }
    }
}
