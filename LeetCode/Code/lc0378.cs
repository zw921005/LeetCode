using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class lc378
    {
        public int KthSmallest(int[][] matrix, int k)
        {
            var length = matrix.Length * matrix[0].Length;
            int[] array = new int[length];
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[0].Length; j++)
                {
                    array[i * matrix.Length + j] = matrix[i][j];
                }
            }
            array = array.OrderBy(i => i).ToArray();
            return array[k - 1];
        }
    }
}
