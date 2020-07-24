using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc064
    {
        public int MinPathSum(int[][] grid)
        {
            int m = grid.Length;
            int n = grid[0].Length;
            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    int left = int.MaxValue; int up = int.MaxValue;
                    if (i > 0) up = grid[i - 1][j];
                    if (j > 0) left = grid[i][j - 1];
                    if (i != 0 || j != 0) {
                        grid[i][j] += Math.Min(up, left);
                    }
                }
            }

            return grid[m - 1][n - 1];
        }
    }
}
