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
    public class lc309Tests
    {
        [TestMethod()]
        public void MaxProfitTest()
        {
            var obj = new lc309();
            int[] prices = { 1, 2, 3, 0, 2 };
            if (obj.MaxProfit(prices) != 3)
            {
                Assert.Fail();
            };
        }
    }
}