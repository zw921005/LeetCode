using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc0070
    {
        public void Test()
        {
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(ClimbStairs(i));
            }
        }

        public static int ClimbStairs(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            int[] dp = new int[n + 1];
            dp[1] = 1;
            dp[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                dp[i] = dp[i - 1] + dp[i - 2];
            }

            return dp[n];
        }

        //static int[] cache = new int[100];

        //public static int ClimbStairs(int n)
        //{
        //    int res;

        //    if (cache[n] > 0)
        //    {
        //        return cache[n];
        //    }
        //    if (n == 0 || n == 1)
        //    {
        //        res = 1;
        //    }
        //    else
        //    {
        //        res = ClimbStairs(n - 1) + ClimbStairs(n - 2);
        //    }

        //    cache[n] = res;
        //    return res;
        //}
    }
}
