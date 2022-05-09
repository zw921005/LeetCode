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
    public class lc0942Tests
    {
        [TestMethod()]
        public void DiStringMatchTest()
        {
            var obj = new lc0942();
            Console.WriteLine(String.Join(",", obj.DiStringMatch("IDID")));
            Console.WriteLine(String.Join(",", obj.DiStringMatch("III")));
            Console.WriteLine(String.Join(",", obj.DiStringMatch("DDI")));
        }
    }
}