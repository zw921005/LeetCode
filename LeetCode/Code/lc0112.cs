using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc112
    {

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;
            if (root.left == null && root.right == null)
                return root.val == sum;
            return HasPathSum(root.left,sum-root.val)|| HasPathSum(root.right, sum - root.val);
        }
    }
}
