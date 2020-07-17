using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    //打开转盘锁
    public class lc752
    {
        public int OpenLock(string[] deadends, string target)
        {
            //if (deadends.Contains("0000")) return -1;
            HashSet<string> dead = new HashSet<string>();
            foreach (var i in deadends) {
                dead.Add(i);
            }
            HashSet<string> visited = new HashSet<string>();
            Queue<string> queue = new Queue<string>();

            int step = 0;
            queue.Enqueue("0000");
            visited.Add("0000");
            while (queue.Count > 0) {
                int size = queue.Count();
                step++;
                while (size > 0) {
                    string s = queue.Dequeue();
                    if (!dead.Contains(s)) {
                        List<string> list = new List<string>();
                        for (int i = 0; i < 4; i++) {
                            foreach (int d in new int[] { -1, 1 }) {
                                int y = (s[i] - '0' + d + 10) % 10;
                                string val = s.Substring(0, i) + y + s.Substring(i + 1);
                                if (target == val) return step;
                                if (!visited.Contains(val)) {
                                    visited.Add(val);
                                    queue.Enqueue(val);
                                }
                            }
                        }
                    }
                    size--;
                }
            }

            return -1;
        }
    }
}
