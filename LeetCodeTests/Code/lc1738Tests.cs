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
    public class lc1738Tests
    {
        [TestMethod()]
        public void KthLargestValueTest()
        {
            int[][] matrix = new int[][]
            {
                new int[]{ 5,2},
                new int[]{ 1,6}
            };
            if (lc1738.KthLargestValue(matrix, 1) != 7) {
                Assert.Fail();
            }
        }
    }
}