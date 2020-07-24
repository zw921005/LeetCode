using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    public class lc1025
    {
        public bool DivisorGame(int N)
        {
            bool[] result = new bool[N + 1];

            result[1] = false;
            for (int i = 2; i <= N; i++) {
                var list = new HashSet<int>();
                list.Add(1);
                for (int j = 2; j * j <= i; j++) {
                    if (i / j * j == i) {
                        list.Add(j);
                        list.Add(i / j);
                    }
                }


                foreach (var index in list) {
                    if (result[i - index] == false) {
                        result[i] = true;
                    }
                }
            }

            return result[N];
        }

        public bool DivisorGame1(int N)
        {
            return N % 2 == 0;
        }
    }
}
