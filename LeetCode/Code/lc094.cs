using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    /// <summary>
    /// 二叉树的中序遍历
    /// </summary>
    class lc094
    {
        /// <summary>
        /// 递归
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public IList<int> InorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
                return result;
            sub(root, result);
            return result;
        }

        public void sub(TreeNode root, List<int> result)
        {
            if (root.left != null)
                sub(root.left, result);
            result.Add(root.val);
            if (root.right != null)
                sub(root.right, result);
        }


        public IList<int> InorderTraversal1(TreeNode root)
        {
            var result = new List<int>();
            var stack = new Stack<TreeNode>();
            var cur = root;

            while (cur != null || stack.Count > 0) {
                while (cur != null) {
                    stack.Push(cur);
                    cur = cur.left;
                }
                cur = stack.Pop();
                result.Add(cur.val);
                cur = cur.right;
            }

            return result;
        }
    }
}
