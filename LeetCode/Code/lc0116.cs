using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc116
    {
        // Definition for a Node.
        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }

        public Node Connect(Node root)
        {
            if (root == null)
                return null;

            var queue = new Queue<Node>();
            queue.Enqueue(root);
            while (queue.Count() > 0)
            {
                int len = queue.Count();
                while (len > 0)
                {
                    Node node = queue.Dequeue();
                    if (len > 1)
                    {
                        node.next = queue.Peek();
                    }
                    if (node.left != null)
                        queue.Enqueue(node.left);
                    if (node.right != null)
                        queue.Enqueue(node.right);
                    len--;
                }
            }
            return root;
        }
    }
}
