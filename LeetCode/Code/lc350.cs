using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc350
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            var result = new List<int>();
            if (nums1.Length == 0 || nums2.Length == 0)
                return new int[] { };

            Array.Sort(nums1);
            Array.Sort(nums2);

            var p1 = 0;
            var p2 = 0;

            while (p1 < nums1.Length && p2 < nums2.Length)
            {
                if (nums1[p1] < nums2[p2])
                {
                    p1++;
                }
                else if (nums1[p1] == nums2[p2])
                {
                    result.Add(nums1[p1]);
                    p1++; p2++;
                }
                else if (nums1[p1] > nums2[p2])
                {
                    p2++;
                }
            }

            return result.ToArray();
        }
    }
}
