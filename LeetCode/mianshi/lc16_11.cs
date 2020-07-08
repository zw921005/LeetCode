using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mianshi
{
    public class lc16_11
    {
        public int[] DivingBoard1(int shorter, int longer, int k)
        {
            var result = new LinkedList<int>();
            if (k == 0)
                return result.ToArray();
            result.AddLast(shorter * k);
            if (shorter == longer)
                return result.ToArray();

            int val = result.Last();
            int step = longer - shorter;
            for (int i = 1; i <= k; i++)
            {
                val += step;
                result.AddLast(val);
            }

            return result.ToArray();
        }

        public int[] DivingBoard2(int shorter, int longer, int k)
        {
            int length = 0;
            if (k == 0)
                length = 0;
            else if (shorter == longer)
                length = 1;
            else
                length = k + 1;

            var result = new int[length];
            if (k == 0)
                return result;
            else
            {
                result[0] = shorter * k;
                if (shorter == longer)
                    return result;
                else
                {
                    int val = result[0];
                    int step = longer - shorter;
                    for (int i = 1; i <= k; i++)
                    {
                        val += step;
                        result[i] = val;
                    }
                    return result;
                }
            }            
        }

        public int[] DivingBoard(int shorter, int longer, int k)
        {
            if (k == 0)
            {
                return new int[0];
            }

            if (shorter == longer)
            {
                return new int[] { shorter * k };
            }

            int[] lengths = new int[k + 1];
            for (int i = 0; i <= k; i++)
            {
                lengths[i] = shorter * (k - i) + longer * i;
            }

            return lengths;
        }
    }
}
