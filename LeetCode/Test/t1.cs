using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Test
{
    class t1
    {
//        给定两个字符串 s 和 t，它们只包含小写字母。

//字符串 t 由字符串 s 随机重排，然后在随机位置添加一个字母。

//请找出在 t 中被添加的字母。

 

//示例:

//输入：
//s = "abcd"
//t = "abcde"

//输出：
//e

//解释：
//'e' 是那个被添加的字母。


        public char FindTheDifference(string s, string t)
        {
            Dictionary<char, int> maps = new Dictionary<char, int>();
            Dictionary<char, int> mapt = new Dictionary<char, int>();

            foreach(char c in s)
            {
                if (maps.ContainsKey(c))
                    maps[c] += 1;
                else
                    maps.Add(c, 1);
            }

            foreach (char c in t)
            {
                if (mapt.ContainsKey(c))
                    mapt[c] += 1;
                else
                    mapt.Add(c, 1);
            }

            foreach (char key in mapt.Keys)
            {
                if (!maps.ContainsKey(key))
                    return key;
                if (maps[key] != mapt[key])
                    return key;
            }
            return 'c';
        }
    }
}
