using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    static class Helper
    {
        static public void Print(this IEnumerable<int> nums)
        {
            Console.WriteLine("[" + string.Join(",", nums) + "]");
        }

        static public void Print(this int num)
        {
            Console.WriteLine(num);
        }

        static public bool IsNumeric(string str)
        {
            try
            {
                Int32 num =  Convert.ToInt32(str);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
