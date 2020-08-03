using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc0415
    {
        public string AddStrings(string num1, string num2)
        {
            string ans = "";
            int i = num1.Length - 1; int j = num2.Length - 1; int f = 0;

            while (i >= 0 || j >= 0 || f > 0) {
                int x = i >= 0 ? num1[i] - '0' : 0;
                int y = j >= 0 ? num2[j] - '0' : 0;
                int t = x + y + f;
                ans = ans.Insert(0, Convert.ToChar('0' + t % 10).ToString());
                f = t >= 10 ? 1 : 0;
                i--; j--;
            }

            return ans;
        }
    }
}
