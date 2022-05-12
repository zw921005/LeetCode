using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc0944
    {
        public int MinDeletionSize(string[] strs)
        {
            int result = 0;

            for (int i = 0; i < strs[0].Length; i++)
            {
                for (int j = 0; j < strs.Length - 1; j++)
                {
                    if (strs[j][i] > strs[j + 1][i])
                    {
                        result++;
                        break;
                    }
                }
            }

            return result;
        }
    }
}
