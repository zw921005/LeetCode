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
    public class lc0415Tests
    {
        [TestMethod()]
        public void AddStringsTest()
        {
            var obj = new lc0415();
            if (obj.AddStrings("0", "0") != "0") {
                Assert.Fail();
            };

            if (obj.AddStrings("0", "9") != "9") {
                Assert.Fail();
            };
        }
    }
}