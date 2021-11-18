using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// 假设你是一位很棒的家长，想要给你的孩子们一些小饼干。但是，每个孩子最多只能给一块饼干。对每个孩子 i ，都有一个胃口值 gi ，这是能让孩子们满足胃口的饼干的最小尺寸；并且每块饼干 j ，都有一个尺寸 sj 。如果 sj >= gi ，我们可以将这个饼干 j 分配给孩子 i ，这个孩子会得到满足。你的目标是尽可能满足越多数量的孩子，并输出这个最大数值。
    /// </summary>
    class lc455
    {
        public void Test()
        {
            int[] g = { 1, 2, 3 };//1
            int[] s = { 1, 1 };
            Console.WriteLine(FindContentChildren(g, s));
            g = new int[] { 1, 2 };//2
            s = new int[] { 1, 2, 3 };
            Console.WriteLine(FindContentChildren(g, s));
            g = new int[] { 1, 2, 3 };//1
            s = new int[] { 3 };
            Console.WriteLine(FindContentChildren(g, s));
            g = new int[] { };
            s = new int[] { };
            Console.WriteLine(FindContentChildren(g, s));
        }

        public int FindContentChildren(int[] g, int[] s)
        {
            int sum = 0;
            int j = 0;
            g = g.OrderBy(i => i).ToArray();
            s = s.OrderBy(i => i).ToArray();
            for (int i = 0; i < g.Length; i++)
            {
                while (j < s.Length && g[i] > s[j])
                {
                    j++;
                }
                if (j < s.Length)
                {
                    sum += 1;
                    j++;
                }
                else
                {
                    break;
                }
            }
            return sum;
        }
    }
}
