using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc279
    {
        public int NumSquares(int n)
        {
            int[] result = new int[n + 1];
            int max = Convert.ToInt32(Math.Sqrt(n));
            int[] square_nums = new int[max + 1];
            for (int i = 1; i <= max; i++) {
                square_nums[i] = i * i;
            }

            result[0] = 0;
            for (int i = 1; i <= n; i++) {
                result[i] = int.MaxValue;
            }
            for (int i = 1; i <= n; i++) {
                foreach (int square in square_nums) {
                    if (i >= square)
                        result[i] = Math.Min(result[i - square] + 1, result[i]);
                    else
                        break;
                }
            }

            return result[n];
        }

        public int NumSquares1(int n)
        {
            int max = Convert.ToInt32(Math.Sqrt(n));
            int[] square_nums = new int[max + 1];
            for (int i = 1; i <= max; i++) {
                square_nums[i] = i * i;
            }

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(n);

            int depth = 0;
            while (queue.Count > 0) {
                depth++;
                int size = queue.Count;
                while (size > 0) {
                    int val = queue.Dequeue();
                    size--;
                    foreach (int square in square_nums) {
                        if (val == square) {
                            return depth;
                        }
                        else if (val > square) {
                            queue.Enqueue(val - square);
                        }
                        else {
                            break;
                        }
                    }
                }
            }

            return depth;
        }
    }
}
