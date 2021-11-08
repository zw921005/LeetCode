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
    public class lc322Tests
    {
        [TestMethod()]
        public void CoinChange()
        {
            var obj = new lc322();
            var result = obj.CoinChange(new int[] { 1, 2, 5 }, 11);
            Assert.AreEqual(result, 3);

            Assert.AreEqual(obj.CoinChange(new int[] { 2 }, 3), -1);
            Assert.AreEqual(obj.CoinChange(new int[] { 1 }, 0), 0);
            Assert.AreEqual(obj.CoinChange(new int[] { 1 }, 1), 1);
            Assert.AreEqual(obj.CoinChange(new int[] { 1 }, 2), 2);
        }
    }
}

