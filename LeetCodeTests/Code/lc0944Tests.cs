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
    public class lc0944Tests
    {
        [TestMethod()]
        public void MinDeletionSizeTest()
        {
            var obj = new lc0944();
            Assert.AreEqual(obj.MinDeletionSize(new string[] { "cba", "daf", "ghi" }), 1);
            Assert.AreEqual(obj.MinDeletionSize(new string[] { "a", "b" }), 0);
            Assert.AreEqual(obj.MinDeletionSize(new string[] { "zyx", "wvu", "tsr" }), 3);
        }
    }
}