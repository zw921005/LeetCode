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
    public class lc474Tests
    {
        [TestMethod()]
        public void FindMaxForm()
        {
            var obj = new lc474();
            var result = obj.FindMaxForm(new string[] { "10", "0001", "111001", "1", "0" }, 5, 3);
            Assert.AreEqual(result, 4);
        }
    }
}

