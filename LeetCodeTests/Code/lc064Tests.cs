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
    public class lc064Tests
    {
        [TestMethod()]
        public void MinPathSumTest()
        {
            int[][] grid = new int[][] {
                new int[]{1,3,1},
                new int[]{1,5,1},
                new int[]{4,2,1}
            };

            var obj = new lc064();
            if (obj.MinPathSum(grid) != 7) {
                Assert.Fail();
            }
        }
    }
}