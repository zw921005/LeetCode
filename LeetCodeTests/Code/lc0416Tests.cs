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
    public class lc416Tests
    {
        [TestMethod()]
        public void CanPartition()
        {
            var obj = new lc416();
            Assert.AreEqual(obj.CanPartition(new int[] { 1, 2, 3, 4, 5, 6, 7}), true);
            Assert.AreEqual(obj.CanPartition(new int[] { 2, 2, 3, 5}), false);
            Assert.AreEqual(obj.CanPartition(new int[] { 1, 5, 11, 5 }), true);
            Assert.AreEqual(obj.CanPartition(new int[] { 1, 2, 3, 5 }), false);
        }
    }
}

