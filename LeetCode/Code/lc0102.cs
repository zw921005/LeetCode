using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc102
    {
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            var result = new List<List<int>>();
            if (root == null)
                return result.ToArray();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count() > 0)
            {
                int len = queue.Count();
                var level = new List<int>();
                while (len > 0)
                {
                    TreeNode node = queue.Dequeue();
                    level.Add(node.val);
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                    len--;
                }
                result.Add(level);
            }
            return result.ToArray();
        }
    }
}
