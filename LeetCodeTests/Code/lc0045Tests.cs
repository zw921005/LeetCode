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
    public class lc0045Tests
    {
        [TestMethod()]
        public void JumpTest()
        {
            var obj = new LeetCode.Code.lc0045();
            Assert.AreEqual(obj.Jump(new int[] { 2, 3, 1, 1, 4 }), 2);
            Assert.AreEqual(obj.Jump(new int[] { 2, 3, 0, 1, 4 }), 2);
        }
    }
}