using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.explore.binaryTree
{
    class MaxDepthClass
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;

            int left_depth = 0;
            int right_depth = 0;
            if (root.left != null)
                left_depth = MaxDepth(root.left);
            if (root.right != null)
                right_depth = MaxDepth(root.right);
            return Math.Max(left_depth, right_depth) + 1;
        }

        private int result = 0;
        public int MaxDepth1(TreeNode root)
        {
            if (root == null)
                return 0;
            Sub(root, 1);
            return result;
        }

        public void Sub(TreeNode root, int depth)
        {
            if (root.left != null)
                Sub(root.left, depth+1);
            if (root.right != null)
                Sub(root.right, depth+1);

            result = Math.Max(result, depth);
        }
    }
}
