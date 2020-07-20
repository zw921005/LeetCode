using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc097
    {
        private Dictionary<string, bool> cache;
        private bool result = false;
        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <param name="s3"></param>
        /// <returns></returns>
        public bool IsInterleave1(string s1, string s2, string s3)
        {
            if (s1.Length + s2.Length != s3.Length) return false;
            sub(s1, s2, s3);
            return result;
        }

        public void sub(string s1, string s2, string s3)
        {
            var key = s1 + "," + s1 + "," + s3;
            if (s1 == s3 || s2 == s3) {
                result = true;
                return;
            }
            if (s1.Length > 0 && s1[0] == s3[0]) {
                IsInterleave(s1.Substring(1), s2, s3.Substring(1));
                if (result == true) cache.Add(key, true);
            }
            if (s2.Length > 0 && s2[0] == s3[0]) {
                IsInterleave(s1, s2.Substring(1), s3.Substring(1));
                if (result == true) cache.Add(key, true);
            }
        }

        public bool IsInterleave(string s1, string s2, string s3)
        {
            int len1 = s1.Length, len2 = s2.Length, len3 = s3.Length;
            if (len1 + len2 != len3) return false;
            bool[,] result = new bool[len1 + 1, len2 + 1];
            result[0, 0] = true;
            for (int i = 0; i <= len1; i++) {
                for (int j = 0; j <= len2; j++) {
                    if (i > 0)
                        result[i, j] = result[i, j] || result[i - 1, j] && s1[i - 1] == s3[i + j - 1];
                    if (j > 0)
                        result[i, j] = result[i, j] || result[i, j - 1] && s2[j - 1] == s3[i + j - 1];
                }
            }

            return result[len1, len2];
        }

        public bool IsInterleave3(string s1, string s2, string s3)
        {
            int len1 = s1.Length, len2 = s2.Length, len3 = s3.Length;
            if (len1 + len2 != len3) return false;
            bool[] result = new bool[len2 + 1];
            result[0] = true;
            for (int i = 0; i <= len1; i++) {
                for (int j = 0; j <= len2; j++) {
                    if (i > 0)
                        result[j] = result[j] && s1[i - 1] == s3[i + j - 1];
                    if (j > 0)
                        result[j] = result[j] || result[j - 1] && s2[j - 1] == s3[i + j - 1];
                }
            }

            return result[len2];
        }
    }
}
