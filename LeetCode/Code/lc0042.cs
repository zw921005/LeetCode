using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc0042
    {
        public int Trap(int[] height)
        {
            if(height.Length == 0)
                return 0;
            int[] leftMax = new int[height.Length];
            int[] rightMax = new int[height.Length];

            leftMax[0] = height[0];
            for (int i = 1; i < height.Length; i++)
            {
                leftMax[i] = Math.Max(height[i], leftMax[i - 1]);
            }

            rightMax[height.Length - 1] = height[height.Length - 1];
            for (int i = height.Length - 2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(height[i], rightMax[i + 1]);
            }

            int result = 0;
            for (int i = 0; i < height.Length; i++)
            {
                result += Math.Min(leftMax[i], rightMax[i]) - height[i];
            }
            return result;
        }
    }
}
