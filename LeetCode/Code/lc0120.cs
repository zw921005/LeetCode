using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc120
    {
        public int MinimumTotal(IList<IList<int>> triangle)
        {
            if (triangle.Count == 0 || triangle == null)
                return 0;
            int[] result = triangle.Last().ToArray();

            for (int i = triangle.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j < triangle[i].Count; j++)
                {
                    result[j] = Math.Min(result[j], result[j + 1]) + triangle[i][j];
                }
            }

            return result[0];
        }

        public int MinimumTotal1(IList<IList<int>> triangle)
        {
            if (triangle.Count == 0 || triangle == null)
                return 0;

            for (int i = triangle.Count - 2; i >= 0; i--)
            {
                for (int j = 0; j < triangle[i].Count; j++)
                {
                    triangle[i][j] += Math.Min(triangle[i + 1][j], triangle[i + 1][j + 1]);
                }
            }

            return triangle[0][0];
        }
    }
}
