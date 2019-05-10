using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    static public class Helper
    {
        static public void Print(this int num) 
        {
            Console.WriteLine(num);
        }

        static public void Print(this IEnumerable<int> nums)
        {
            Console.WriteLine("[" + string.Join(",", nums) + "]");
        }

        static public void Print(this IEnumerable<IEnumerable<int>> nums)
        {
            foreach (IEnumerable<int> num in nums)
            {
                Console.WriteLine("[" + string.Join(",", num) + "]");
            }
        }

        static public void Print0<T>(this T num) where T : struct
        {
            Console.WriteLine(num);
        }

        static public void Print1<T>(this IEnumerable<T> nums) where T : struct
        {
            Console.WriteLine("[" + string.Join(",", nums) + "]");
        }

        static public void Print2<T>(this IEnumerable<IEnumerable<T>> nums) where T : struct
        {
            foreach (IEnumerable<T> num in nums)
            {
                Console.WriteLine("[" + string.Join(",", num) + "]");
            }
        }

        static public void Swap<T>(ref T a, ref T b)
        {
            T t = a;
            a = b;
            b = t;
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
