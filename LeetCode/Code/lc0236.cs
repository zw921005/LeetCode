using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    /// <summary>
    /// 二叉树的最近公共祖先
    /// </summary>
    class lc236
    {
        private TreeNode ans;

        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            this.dfs(root, p, q);
            return ans;
        }

        public bool dfs(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return false;
            bool lson = dfs(root.left, p, q);
            bool rson = dfs(root.right, p, q);
            if ((lson && rson) || ((root.val == p.val || root.val == q.val) && (lson || rson))) {
                ans = root;
            }
            return lson || rson || (root.val == p.val || root.val == q.val);
        }
    }
}
