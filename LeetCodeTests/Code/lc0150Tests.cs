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
    public class lc150Tests
    {
        [TestMethod()]
        public void EvalRPNTest()
        {
            var data = new string[] { "4", "13", "5", "/", "+" };
            var obj = new lc150();
            if (obj.EvalRPN(data) != 6) {
                Assert.Fail();
            };
        }
    }
}