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
    public class lc16_11Tests
    {
        [TestMethod()]
        public void DivingBoardTest()
        {
            var obj = new lc16_11();
            int[] input = new int[] { 9, 8436, 28489 };
            obj.DivingBoard(input[0], input[1], input[2]);
        }
    }
}