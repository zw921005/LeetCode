using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc474
    {
        public int FindMaxForm(string[] strs, int m, int n)
        {
            int[,] dp = new int[m + 1, n + 1];
            for (int i = 1; i <= strs.Length; i++)
            {
                var zo = GetZerosOnes(strs[i - 1]);
                int zeros = zo[0], ones = zo[1];

                for (int j = m; j >= zeros; j--)
                {
                    for (int k = n; k >= ones; k--)
                    {
                        if (j >= zeros && k >= ones)
                        {
                            dp[j, k] = Math.Max(dp[j, k], dp[j - zeros, k - ones] + 1);
                        }
                    }
                }
            }
            return dp[m, n];
        }

        public int FindMaxForm1(string[] strs, int m, int n)
        {
            int[,,] dp = new int[strs.Length + 1, m + 1, n + 1];
            for (int i = 1; i <= strs.Length; i++)
            {
                var zo = GetZerosOnes(strs[i - 1]);
                int zeros = zo[0], ones = zo[1];

                for (int j = 0; j <= m; j++)
                {
                    for (int k = 0; k <= n; k++)
                    {
                        dp[i, j, k] = dp[i - 1, j, k];
                        if (j >= zeros && k >= ones)
                        {
                            dp[i, j, k] = Math.Max(dp[i, j, k], dp[i - 1, j - zeros, k - ones] + 1);
                        }
                    }
                }
            }
            return dp[strs.Length, m, n];
        }

        public int[] GetZerosOnes(string str)
        {
            int[] zo = new int[2];
            foreach (var c in str)
            {
                zo[c - '0']++;
            }
            return zo;
        }

    }
}
