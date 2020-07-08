using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.explore.binaryTree.digui
{
    class IsSymmetricClass
    {
        public bool IsSymmetric(TreeNode root)
        {
            return Check(root, root);
        }

        public bool Check(TreeNode p,TreeNode q)
        {
            if (p == null && q == null)
                return true;
            if (p == null || q == null)
                return false;

            return p.val == q.val && Check(p.left, q.right) && Check(p.right, q.left);
        }
    }
}
