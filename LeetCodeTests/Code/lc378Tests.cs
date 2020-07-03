using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Tests
{
    [TestClass()]
    public class lc378Tests
    {
        [TestMethod()]
        public void KthSmallestTest()
        {
            var obj = new lc378();
            var matrix = new int[][] {
                new int[] { 1, 5, 9 },
                new int[]{ 10, 11, 13 },
                new int[] { 12, 13, 15 }};
            var k = 8;
            if (obj.KthSmallest(matrix, k) != 13)
            {
                Assert.Fail();
            }
        }
    }
}