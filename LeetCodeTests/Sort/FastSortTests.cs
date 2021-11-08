using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCode.Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Sort.Tests
{
    [TestClass()]
    public class FastSortTests
    {
        [TestMethod()]
        public void SortTest()
        {
            int[] arr = new int[] { 4, 6, 9, 3, 0, 1, 2, 5 };
            FastSort.Sort(arr);
            return;
        }
    }
}