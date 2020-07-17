using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc739
    {
        public int[] dailyTemperatures(int[] T)
        {
            int[] result = new int[T.Length];
            int[] location = new int[101];

            for (int i = T.Length - 1; i >= 0; i--) {
                for (int j = T[i] + 1; j <= 100; j++) {
                    if (location[j] != 0) {
                        result[i] = location[j] - i;
                        break;
                    }
                }
                location[T[i]] = i;
            }

            return result;
        }
    }
}
