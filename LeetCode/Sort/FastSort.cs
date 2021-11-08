using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Sort
{
    public class FastSort
    {
        public static int[] Sort(int[] arr)
        {
            Sorted(arr, 0, arr.Length - 1);
            return arr;
        }

        public static void Sorted(int[] arr, int l, int r)
        {
            if (l >= r) return;
            int x = arr[0];
            int j = 1;
            for (int i = l + 2; i <= r; i++) {
                if (arr[i] < x) {
                    swap(arr, j++, i);
                }
            }
            swap(arr, 0, --j);
            Sorted(arr, l, j - 1);
            Sorted(arr, j + 1, r);
        }

        public static void swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}
