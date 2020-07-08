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
    public class lc063_1Tests
    {
        [TestMethod()]
        public void UniquePathsWithObstaclesTest()
        {
            var obj = new lc063_1();
            var grid = new int[][]
            {
                new int[]{ 0,0,0},
                new int[]{ 0,1,0},
                new int[]{ 0,0,0}
            };
            if (obj.UniquePathsWithObstacles(grid) != 2)
            {
                Assert.Fail();
            }

            grid = new int[][]
            {
                new int[]{ 1}
            };
            if (obj.UniquePathsWithObstacles(grid) != 0)
            {
                Assert.Fail();
            }
        }
    }
}