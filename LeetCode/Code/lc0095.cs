using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc095
    {
        public IList<TreeNode> GenerateTrees(int n)
        {
            if (n == 0) return new List<TreeNode>();
            return generateTrees(1, n);
        }

        public List<TreeNode> generateTrees(int start, int end)
        {
            List<TreeNode> allTrees = new List<TreeNode>();
            if (start > end) {
                allTrees.Add(null);
                return allTrees;
            }

            for (int i = start; i <= end; i++) {
                List<TreeNode> leftTrees = generateTrees(start, i - 1);
                List<TreeNode> rightTrees = generateTrees(i + 1, end);
                foreach (TreeNode left in leftTrees) {
                    foreach(TreeNode right in rightTrees) {
                        TreeNode curTree = new TreeNode(i, left, right);
                        allTrees.Add(curTree);
                    }
                }
            }

            return allTrees;
        }
    }
}
