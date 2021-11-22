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
    public class lc0055Tests
    {
        [TestMethod()]
        public void CanJumpTest()
        {
            var obj = new LeetCode.Code.lc0055();
            Assert.AreEqual(obj.CanJump(new int[] { 2, 3, 1, 1, 4 }), true);
            Assert.AreEqual(obj.CanJump(new int[] { 3, 2, 1, 0, 4 }), false);
            Assert.AreEqual(obj.CanJump(new int[] { 0, 2, 3 }), false);
            Assert.AreEqual(obj.CanJump(new int[] { 1, 2, 3 }), true);
            Assert.AreEqual(obj.CanJump(new int[] { 1, 2 }), true);
            Assert.AreEqual(obj.CanJump(new int[] { 0 }), true);
        }
    }
}