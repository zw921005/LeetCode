using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc105
    {
        int[] inorder;
        int[] preorder;
        int pre_idx;
        Dictionary<int, int> dict = new Dictionary<int, int>();

        public TreeNode sub(int left, int right)
        {
            if (left > right)
                return null;

            int val = preorder[pre_idx];
            var root = new TreeNode(val);
            pre_idx++;

            var index = dict[val];

            root.left = sub(left, index - 1);
            root.right = sub(index + 1, right);

            return root;
        }

        public TreeNode BuildTree(int[] preorder, int[] inorder)
        {
            this.inorder = inorder;
            this.preorder = preorder;
            pre_idx = 0;

            for (int i = 0; i < inorder.Length; i++)
            {
                dict.Add(inorder[i], i);
            }

            return sub(0, inorder.Length - 1);
        }
    }
}
