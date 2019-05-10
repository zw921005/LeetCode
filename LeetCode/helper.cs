using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    static public class Helper
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
                Int32 num = Convert.ToInt32(str);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        static public bool Equals<T>(T[] a, T[] b)
        {
            if (a.Length != b.Length)
            {
                return false;
            }

            for(int i = 0; i < a.Length; i++)
            {
                if (!a[i].Equals( b[i]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
