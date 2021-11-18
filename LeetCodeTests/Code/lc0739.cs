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
    public class lc739Tests
    {
        [TestMethod()]
        public void dailyTemperaturesTest()
        {
            var obj = new lc739();
            obj.dailyTemperatures1(new int[] { 73, 74, 75, 71, 69, 72, 76, 73 });
        }
    }
}