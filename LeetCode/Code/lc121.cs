using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc121
    {
        static void Main(string[] args)
        {
            //int[] input = { 7, 1, 5, 3, 6, 4 };
            int[] input = { 2, 6, 1, 4 };
            int output = MaxProfit(input);
            Console.WriteLine(output);
            Console.Read();
        }

        public static int MaxProfit(int[] prices)
        {
            int max = 0;
            if (prices.Length > 0)
            {
                int min = prices[0];
                for (int i = 1; i < prices.Length; i++)
                {
                    if (prices[i] < min)
                    {
                        min = prices[i];
                    }
                    else if (prices[i] - min > max)
                    {
                        max = prices[i] - min;
                    }
                }
            }

            return max;
        }

        //public static int MaxProfit(int[] prices)
        //{
        //    int max = 0;
        //    for (int i = 0; i < prices.Length; i++)
        //    {
        //        for (int j = i; j < prices.Length; j++)
        //        {
        //            if (prices[j] - prices[i] > max)
        //            {
        //                max = prices[j] - prices[i];
        //            }
        //        }
        //    }
        //    return max;
        //}
    }
}
