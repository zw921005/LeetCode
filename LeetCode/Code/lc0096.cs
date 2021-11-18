using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc096
    {
        public int NumTrees(int n)
        {
            if (n < 2) return 1;

            int[] result = new int[n + 1];
            result[0] = 1;
            result[1] = 1;
            for (int i = 2; i <= n; i++) {
                for (int j = 0; j < i; j++) {
                    result[i] += result[j] * result[i - j - 1];
                }
            }

            return result[n];
        }

        public int NumTrees1(int n)
        {
            int C = 1;
            for (int i = 0; i < n; i++) {
                C = C * 2 * (2 * i + 1) / (i + 2);
            }
            return (int)C;
        }
    }
}
