using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    class lc167
    {
        public int[] twoSum(int[] numbers, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 1; i < numbers.Length; i++) {
                if (!map.ContainsKey(numbers[i - 1]))
                    map.Add(numbers[i - 1], i);
            }

            for (int i = 1; i <= numbers.Length; i++) {
                if (map.ContainsKey(target - numbers[i - 1]) && map[target - numbers[i - 1]] != i) {
                    if (i > map[target - numbers[i - 1]]) {
                        result[0] = map[target - numbers[i - 1]]; result[1] = i;
                    }
                    else {
                        result[0] = i; result[1] = map[target - numbers[i - 1]];
                    }
                }
            }
            return result;
        }

        public int[] twoSum1(int[] numbers, int target)
        {
            int low = 1;int high = numbers.Length;
            while (low < high) {
                if (numbers[low - 1] + numbers[high-1] == target) {
                    return new int[] { low, high };
                }
                else if(numbers[low - 1] + numbers[high-1] > target) {
                    high--;
                }
                else {
                    low++;
                }
            }

            return new int[] { -1, -1 };
        }
    }
}
