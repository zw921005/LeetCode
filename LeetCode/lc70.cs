using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc70
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(ClimbStairs(i));
            }
            Console.Read();
        }

        static int[] cache = new int[100];

        public static int ClimbStairs(int n)
        {
            int res;

            if (cache[n] > 0)
            {
                return cache[n];
            }
            if (n == 0 || n == 1)
            {
                res = 1;
            }
            else
            {
                res = ClimbStairs(n - 1) + ClimbStairs(n - 2);
            }

            cache[n] = res;
            return res;
        }
    }
}
