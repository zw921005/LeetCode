using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc104
    {
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            var level = 0;
            while (queue.Count > 0) {
                int size = queue.Count;
                level += 1;
                for(int i = 0; i < size; i++) {
                    var node = queue.Dequeue();
                    if (node.left != null) {
                        queue.Enqueue(node.left);
                    }
                    if (node.right != null) {
                        queue.Enqueue(node.right);
                    }
                }
            }
            
            return level;
        }
    }
}
