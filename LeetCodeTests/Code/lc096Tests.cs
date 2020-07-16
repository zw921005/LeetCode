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
    public class lc096Tests
    {
        [TestMethod()]
        public void NumTreesTest()
        {
            var obj = new lc096();
            if (obj.NumTrees(3)!= 5)
            {
                Assert.Fail();
            }
        }
    }
}