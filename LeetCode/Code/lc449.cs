using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc449
    {
        // Encodes a tree to a single string.
        public string serialize(TreeNode root)
        {
            if (root == null)
                return "";
            var result = new List<string>();
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count() > 0) {
                TreeNode node = queue.Dequeue();
                if (node != null) {
                    result.Add(node.val.ToString());
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
                else {
                    result.Add("null");
                }
            }
            return string.Join(",", result);
        }

        // Decodes your encoded data to tree.
        public TreeNode deserialize(string data)
        {
            if (string.IsNullOrEmpty(data))
                return null;
            var vals = data.Split(',');
            TreeNode root = new TreeNode(Convert.ToInt32(vals[0]));
            var queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int i = 1;
            while (queue.Count() > 0) {
                var node = queue.Dequeue();
                if (vals[i] != "null") {
                    node.left = new TreeNode(Convert.ToInt32(vals[i]));
                    queue.Enqueue(node.left);
                }
                i++;
                if (vals[i] != "null") {
                    node.right = new TreeNode(Convert.ToInt32(vals[i]));
                    queue.Enqueue(node.right);
                }
                i++;
            }
            return root;
        }
    }
}
