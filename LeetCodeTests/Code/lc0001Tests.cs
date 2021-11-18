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
    public class lc001Tests
    {
        [TestMethod()]
        public void TwoSumTest()
        {
            var obj = new lc001();
            var result = obj.TwoSum(new[] { 2, 7, 11, 15 }, 9);
            if (!Helper.Equals(result, new[] { 0, 1 }))
            {
                Assert.Fail();
            };
        }
    }
}