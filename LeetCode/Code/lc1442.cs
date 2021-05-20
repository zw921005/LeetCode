using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc1442
    {
        public static int CountTriplets(int[] arr)
        {
            int n = arr.Length;
            int[] s = new int[n + 1];
            for (int i = 0; i < n; ++i) {
                s[i + 1] = s[i] ^ arr[i];
            }
            Dictionary<int, int> cnt = new Dictionary<int, int>();
            Dictionary<int, int> total = new Dictionary<int, int>();
            int ans = 0;
            for (int k = 0; k < n; ++k) {
                if (cnt.ContainsKey(s[k + 1])) {
                    ans += cnt[s[k + 1]] * k - total[s[k + 1]];
                }
                if (!cnt.ContainsKey(s[k])) {
                    cnt.Add(s[k], 1);
                }
                else {
                    ++cnt[s[k]];
                }
                if (!total.ContainsKey(s[k])) {
                    total.Add(s[k], k);
                }
                else {
                    total[s[k]] += k;
                }
            }
            return ans;
        }
    }
}
