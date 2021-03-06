﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc144
    {
        public IList<int> PreorderTraversal(TreeNode root)
        {
            var result = new List<int>();
            if (root == null)
                return result;
            sub(root, result);
            return result;
        }

        public void sub(TreeNode root, List<int> result)
        {
            result.Add(root.val);
            if (root.left != null)
                sub(root.left, result);
            if (root.right != null)
                sub(root.right, result);
        }
    }
}
