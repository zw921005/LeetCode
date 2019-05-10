using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 给定一个数组，它的第 i 个元素是一支给定股票第 i 天的价格。

    //设计一个算法来计算你所能获取的最大利润。你可以尽可能地完成更多的交易（多次买卖一支股票）。

    //注意：你不能同时参与多笔交易（你必须在再次购买前出售掉之前的股票）。
    /// </summary>
    class lc122
    {
        public void Test()
        {
            int[] input = { 7, 1, 5, 3, 6, 4 };//7
            Console.WriteLine(MaxProfit(input));
            input = new int[] { 1, 2, 3, 4, 5 };//4
            Console.WriteLine(MaxProfit(input));
            input = new int[] { 7, 6, 4, 3, 1 };//0
            Console.WriteLine(MaxProfit(input));
            input = new int[] { };//
            Console.WriteLine(MaxProfit(input));
        }

        public int MaxProfit(int[] prices)
        {
            int sum = 0;
            for(int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i + 1] > prices[i])
                {
                    sum += prices[i + 1] - prices[i];
                }
            }
            return sum;
        }
    }
}
