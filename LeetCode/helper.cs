using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    static class Helper
    {
        static public void Print(this int[] nums)
        {
            Console.WriteLine("[" + string.Join(",", nums) + "]");
        }

        static public void Print(this int num)
        {
            Console.WriteLine(num);
        }
    }
}
