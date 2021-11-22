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
    public class lc0918Tests
    {
        [TestMethod()]
        public void MaxSubarraySumCircularTest()
        {
            var obj = new LeetCode.Code.lc0918();
            Assert.AreEqual(obj.MaxSubarraySumCircular(new int[] { 2, -2, 2, 7, 8, 0}), 19);
            Assert.AreEqual(obj.MaxSubarraySumCircular(new int[] { 5, -3, 5 }), 10);
        }
    }
}