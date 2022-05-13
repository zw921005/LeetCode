using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.mianshi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mianshi.Tests
{
    [TestClass()]
    public class lc01_05Tests
    {
        [TestMethod()]
        public void OneEditAwayTest()
        {
            var obj = new lc01_05();
            Assert.AreEqual(obj.OneEditAway("teacher", "attacher"), false);
            Assert.AreEqual(obj.OneEditAway("pale", "ple"), true);
            Assert.AreEqual(obj.OneEditAway("pales", "pal"), false);
        }
    }
}