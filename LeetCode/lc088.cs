using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc088
    {
        public void Test()
        {
            //int[] nums1 = new[] { 1, 2, 3, 0, 0, 0 };
            //int[] nums2 = new[] { 2, 5, 6 };
            //Merge(nums1, 3, nums2, 3);
            int[] nums1 = new[] { 0 };
            int[] nums2 = new[] { 1 };
            Merge(nums1, 0, nums2, 1);
            nums1.Print();
        }

        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int index = nums1.Length - 1;
            int i = m - 1, j = n - 1;

            while (index >= 0 && j >= 0)
            {
                if (i >= 0 && nums1[i] > nums2[j])
                {
                    nums1[index] = nums1[i];
                    i--;
                }
                else
                {
                    nums1[index] = nums2[j];
                    j--;
                }
                index--;
            }
        }
    }
}
