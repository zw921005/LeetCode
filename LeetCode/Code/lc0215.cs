using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc215
    {
            Random random = new Random();

            public int FindKthLargest(int[] nums, int k)
            {
                return QuickSelect(nums, 0, nums.Length - 1, nums.Length - k);
            }

            public int QuickSelect(int[] a, int l, int r, int index)
            {
                int q = RandomPartition(a, l, r);
                if (q == index) {
                    return a[q];
                }
                else {
                    return q < index ? QuickSelect(a, q + 1, r, index) : QuickSelect(a, l, q - 1, index);
                }
            }

            public int RandomPartition(int[] a, int l, int r)
            {
                int i = random.Next(r - l + 1) + l;
                Swap(a, i, r);
                return Partition(a, l, r);
            }

            public int Partition(int[] a, int l, int r)
            {
                int x = a[r], i = l - 1;
                for (int j = l; j < r; ++j) {
                    if (a[j] <= x) {
                        Swap(a, ++i, j);
                    }
                }
                Swap(a, i + 1, r);
                return i + 1;
            }

            public void Swap(int[] a, int i, int j)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
    }
}
