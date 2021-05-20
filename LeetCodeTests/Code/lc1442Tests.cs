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
    public class lc1442Tests
    {
        [TestMethod()]
        public void CountTripletsTest()
        {
            int[] arr = new int[] { 1, 1, 1, 1, 1 };
            if (lc1442.CountTriplets(arr) != 10) {
                Assert.Fail();
            }
        }
    }
}