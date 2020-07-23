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
            if (root == null) return result;
            var stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0) {
                var node = stack.Pop();
                if (node.left != null) stack.Push(node.left);
                result.Add(node.val);
                if (node.right != null) stack.Push(node.right);
            }

            return result;
        }
    }
}
