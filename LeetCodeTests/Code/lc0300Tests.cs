using LeetCode.Code;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Code
{
    [TestClass()]
    public class lc300Tests
    {
        [TestMethod()]
        public void LengthOfLIS()
        {
            var l = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            l = l.Where(i => i % 2 == 1).Select(i => i * i).ToList();


            var obj = new lc300();
            Assert.AreEqual(obj.LengthOfLIS(new int[] { 10, 9, 2, 5, 3, 7, 101, 18 }), 4);
        }
    }
}
