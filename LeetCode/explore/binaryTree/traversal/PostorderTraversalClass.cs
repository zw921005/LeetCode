using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.explore.binaryTree
{
    class PostorderTraversalClass
    {
        public IList<int> PostorderTraversal(TreeNode root)
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
            if (root.right != null)
                sub(root.right, result);
            result.Add(root.val);
        }
    }
}
