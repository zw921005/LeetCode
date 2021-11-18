using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeTests.Code
{
    [TestClass()]
    public class lc0213Tests
    {
        [TestMethod()]
        public void Test()
        {
            var obj = new LeetCode.Code.lc0213();
            Assert.AreEqual(obj.Rob(new int[] { 1, 3, 1, 3, 100 }), 103);
            Assert.AreEqual(obj.Rob(new int[] { 200, 3, 140, 20, 10 }), 340);
            Assert.AreEqual(obj.Rob(new int[] { 2, 3, 2 }), 3);
            Assert.AreEqual(obj.Rob(new int[] { 1, 2, 3, 1 }), 4);
            Assert.AreEqual(obj.Rob(new int[] { 0 }), 0);
        }
    }
}
