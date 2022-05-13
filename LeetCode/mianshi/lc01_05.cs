using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.mianshi
{
    public class lc01_05
    {
        public bool OneEditAway(string first, string second)
        {
            if (first.Length < second.Length)
            {
                return OneEditAway(second, first);
            }

            int count = 0;
            if (first.Length > second.Length)
            {
                count++;
                int i = 0;
                for (i = 0; i < first.Length; i++)
                {
                    if (i == second.Length || first[i] != second[i])
                    {
                        break;
                    }
                }
                first = first.Substring(0, i) + first.Substring(i + 1, first.Length - i - 1);
            }

            if (first.Length != second.Length)
                return false;

            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    count++;
                }
            }

            return count <= 1;
        }

    }
}
