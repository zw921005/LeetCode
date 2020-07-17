using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc35
    {
        public int SearchInsert(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] >= target) {
                    return i;
                }
            }
            return nums.Length;
        }

        public int SearchInsert1(int[] nums, int target)
        {
            int left = 0, right = nums.Length - 1;
            while (left < right) {
                int mid = (left + right) / 2;
                if (nums[mid] == target)
                    return mid;
                else if (nums[mid] > target)
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            if (nums[left] >= target)
                return left;
            else
                return left + 1;
        }
    }
}
