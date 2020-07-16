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
    public class lc120Tests
    {
        [TestMethod()]
        public void MinimumTotalTest()
        {
            var obj = new lc120();
            var data = new int[][]
            {
                new int[]{2 },
                new int[]{3,4},
                new int[]{6,5,7},
                new int[]{4,1,8,3}
            };
            if (obj.MinimumTotal(data) != 11)
            {
                Assert.Fail();
            }
        }
    }
}