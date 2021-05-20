using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc1738
    {
        public static int KthLargestValue(int[][] matrix, int k)
        {
            int m = matrix.Length, n = matrix[0].Length;
            int[][] s = new int[m + 1][];
            for (int i = 0; i < m + 1; i++) {
                s[i] = new int[n + 1];
            }

            List<int> list = new List<int>();
            for (int i = 1; i < m + 1; i++) {
                for (int j = 1; j < n + 1; j++) {
                    s[i][j] = s[i - 1][j - 1] ^ s[i][j - 1] ^ s[i - 1][j] ^ matrix[i - 1][j - 1];
                    list.Add(s[i][j]);
                }
            }

            list.Sort();
            return list[list.Count - k];
        }
    }
}
