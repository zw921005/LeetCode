using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code.Tests
{
    [TestClass()]
    public class lc003Tests
    {
        [TestMethod()]
        public void LengthOfLongestSubstringTest()
        {
            var obj = new lc003();
            if (obj.LengthOfLongestSubstring("abcabcbb") != 3)
            {
                Assert.Fail();
            }
            if (obj.LengthOfLongestSubstring("bbbbb") != 1)
            {
                Assert.Fail();
            }
            if (obj.LengthOfLongestSubstring("pwwkew") != 3)
            {
                Assert.Fail();
            }
        }
    }
}