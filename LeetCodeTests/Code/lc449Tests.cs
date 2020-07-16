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
    public class lc449Tests
    {
        [TestMethod()]
        public void serializeTest()
        {
            var obj = new lc449();
            var node1 = new TreeNode(1);
            var node2 = new TreeNode(2);
            var node3 = new TreeNode(3);
            var node4 = new TreeNode(4);
            var node5 = new TreeNode(5);
            node1.left = node2;
            node1.right = node3;
            node3.left = node4;
            node3.right = node5;
            var result = obj.serialize(node1);

            Assert.Fail();
        }
    }
}