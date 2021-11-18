using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    /// <summary>
    /// 递归
    /// </summary>
    public class lc063
    {

        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            var i = obstacleGrid.Length - 1;
            var j = obstacleGrid[0].Length - 1;
            Dictionary<string, int> map = new Dictionary<string, int>();
            return sub(obstacleGrid, i, j, map);
        }

        private int sub(int[][] obstacleGrid, int i, int j, Dictionary<string, int> map)
        {
            var key = i + "," + j;
            var result = 0;
            if (map.ContainsKey(key))
                return map[key];

            if (i == 0 && j == 0)
                result = obstacleGrid[i][j] == 1 ? 0 : 1;
            else if (obstacleGrid[i][j] == 1)
                result = 0;
            else
            {
                if (i > 0)
                    result += sub(obstacleGrid, i - 1, j, map);
                if (j > 0)
                    result += sub(obstacleGrid, i, j - 1, map);
            }

            map.Add(key, result);
            return result;
        }
    }

    /// <summary>
    /// DP
    /// </summary>
    public class lc063_1
    {

        public int UniquePathsWithObstacles(int[][] obstacleGrid)
        {
            int n = obstacleGrid.Length; int m = obstacleGrid[0].Length;

            int[] result = new int[n];
            if (obstacleGrid[0][0] == 1)
                return 0;
            else
                result[0] = 1;

            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    if (obstacleGrid[i][j] == 1)
                    {
                        result[i] = 0;
                        continue;
                    }

                    if (i > 0)
                        result[i] += result[i - 1];
                }
            }
            return result[n - 1];
        }

    }
}
