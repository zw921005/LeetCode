using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc066
    {
        public void Test()
        {
            int[] input = new[] { 9 };
            PlusOne(input).Print();
        }

        public int[] PlusOne(int[] digits)
        {
            int[] result = new int[digits.Length + 1];
            digits[digits.Length - 1] += 1;
            bool flag = false;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                int t = digits[i] + (flag == true ? 1 : 0);
                if (t >= 10)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }

                result[i + 1] = t % 10;
            }
            if (flag == true)
            {
                result[0] = 1;
            }

            if (result[0] == 0)
            {
                int[] newresult = result.Skip(1).ToArray();
                return newresult;
            }
            return result;
        }
    }
}
