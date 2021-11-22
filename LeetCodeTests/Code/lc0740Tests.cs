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
    public class lc0740Tests
    {
        [TestMethod()]
        public void DeleteAndEarnTest()
        {
            var obj = new LeetCode.Code.lc0740();
            Assert.AreEqual(obj.DeleteAndEarn(new int[] { 2, 2, 3, 3, 3, 4 }), 9);
            Assert.AreEqual(obj.DeleteAndEarn(new int[] { 3, 4, 2 }), 6);
            Assert.AreEqual(obj.DeleteAndEarn(new int[] { 1, 2 }), 2);
            Assert.AreEqual(obj.DeleteAndEarn(new int[] { 0 }), 0);
            Assert.AreEqual(obj.DeleteAndEarn(new int[] { }), 0);
        }
    }
}