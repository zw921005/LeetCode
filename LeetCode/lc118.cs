using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc118
    {
        public void Test()
        {
            Generate(5).Print2();
        }

        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> angle = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                List<int> line = new List<int>();
                angle.Add(line);
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        line.Add(1);
                    }
                    else
                    {
                        line.Add(angle[i - 1][j - 1] + angle[i - 1][j]);
                    }
                }
            }

            return angle;
        }
    }
}
