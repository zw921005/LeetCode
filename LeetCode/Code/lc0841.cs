using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc0841
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms)
        {
            var visited = new HashSet<int>();
            visited.Add(0);

            var queue = new Queue<int>();
            queue.Enqueue(0);

            while (queue.Count > 0) {
                var room = queue.Dequeue();
                foreach(var r in rooms[room]) {
                    if (!visited.Contains(r)) {
                        visited.Add(r);
                        queue.Enqueue(r);
                    }
                }
            }

            return rooms.Count == visited.Count();
        }
    }
}
