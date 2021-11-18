using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc0746
    {
        public void Test()
        {
            int[] cost = { 10, 15, 20 };//15
            //Solution();
            Console.WriteLine(MinCostClimbingStairs(cost));
            cost = new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };//6
            //Solution();
            Console.WriteLine(MinCostClimbingStairs(cost));
            cost = new int[] { 0, 0, 0, 0 };//0
            //Solution();
            Console.WriteLine(MinCostClimbingStairs(cost));
        }

        public int MinCostClimbingStairs1(int[] cost)
        {
            int[] dp = new int[cost.Length + 1];
            dp[0] = 0;
            dp[1] = 0;
            for (int i = 2; i <= cost.Length; i++)
            {
                dp[i] = Math.Min(dp[i - 1] + cost[i - 1], dp[i - 2] + cost[i - 2]);
            }
            return dp[cost.Length];
        }

        public int MinCostClimbingStairs(int[] cost)
        {
            int f1 = 0, f2 = 0;
            for (int i = cost.Length - 1; i >= 0; --i)
            {
                int f0 = cost[i] + Math.Min(f1, f2);
                f2 = f1;
                f1 = f0;
            }
            return Math.Min(f1, f2);
        }
        //int[] cache = new int[1000];
        //public void Solution()
        //{
        //    for (int i = 0; i < cache.Length; i++)
        //    {
        //        cache[i] = -1;
        //    }
        //}
        //public int MinCostClimbingStairs(int[] cost)
        //{
        //    int result;
        //    if (cache[cost.Length - 1] != -1)
        //    {
        //        return cache[cost.Length - 1];
        //    }
        //    if (cost.Length == 1)
        //    {
        //        result = 0;
        //    }
        //    else if (cost.Length == 2)
        //    {
        //        result = Math.Min(cost[0], cost[1]);
        //    }
        //    else
        //    {
        //        int a = MinCostClimbingStairs(cost.Take(cost.Length - 2).ToArray()) + cost[cost.Length - 2];
        //        int b = MinCostClimbingStairs(cost.Take(cost.Length - 1).ToArray()) + cost[cost.Length - 1];
        //        result = Math.Min(a, b);
        //    }
        //    cache[cost.Length - 1] = result;
        //    return result;
        //}
    }
}
