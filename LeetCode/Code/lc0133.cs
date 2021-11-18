using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LeetCode.Data.graph;

namespace LeetCode.Code
{
    class lc133
    {
        public Node CloneGraph(Node node)
        {
            if (node == null) return null;
            Dictionary<Node, Node> visited = new Dictionary<Node, Node>();
            return DFS(node, visited);
        }

        public Node DFS(Node node, Dictionary<Node, Node> visited)
        {
            if (visited.ContainsKey(node))
                return visited[node];

            Node clone = new Node(node.val);
            visited.Add(node, clone);
            foreach (Node neighbor in node.neighbors) {
                clone.neighbors.Add(DFS(neighbor, visited));
            }

            return clone;
        }
    }
}
