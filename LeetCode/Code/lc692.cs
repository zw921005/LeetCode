using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc692
    {
        public IList<string> TopKFrequent(string[] words, int k)
        {
            var dict = new Dictionary<string, int>();
            foreach(var w in words) {
                if (dict.ContainsKey(w)) {
                    dict[w] += 1;
                }
                else {
                    dict[w] = 1;
                }
            }

            return dict.OrderByDescending(p => p.Value).ThenBy(p=>p.Key).Take(k).Select(p => p.Key).ToList();
        }
    }
}
