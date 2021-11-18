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
    public class lc752Tests
    {
        [TestMethod()]
        public void OpenLockTest()
        {
            var obj = new lc752();
            string[] deadends = { "0201", "0101", "0102", "1212", "2002" };
            string target = "0202";
            if (obj.OpenLock(deadends, target) != 6) {
                Assert.Fail();
            }
        }
    }
}