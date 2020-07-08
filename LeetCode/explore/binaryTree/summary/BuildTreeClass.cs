using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.explore.binaryTree.summary
{
    class BuildTreeClass
    {
        int[] inorder;
        int[] postorder;
        int post_idx;
        Dictionary<int, int> dict = new Dictionary<int, int>();

        public TreeNode sub(int left,int right)
        {
            if (left > right)
                return null;

            int val = postorder[post_idx];
            var root = new TreeNode(val);
            post_idx--;

            var index = dict[val];

            root.right = sub(index + 1, right);
            root.left = sub(left, index - 1);

            return root;
        }

        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            this.inorder = inorder;
            this.postorder = postorder;
            post_idx = postorder.Length - 1;

            for(int i = 0; i < inorder.Length; i++)
            {
                dict.Add(inorder[i], i);
            }

            return sub(0, inorder.Length - 1);
        }
    }
}
