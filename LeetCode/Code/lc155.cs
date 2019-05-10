using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc155
    {
        public void Test()
        {
            MinStack minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            Console.WriteLine(minStack.GetMin());
            minStack.Pop();
            minStack.Top();
            Console.WriteLine(minStack.GetMin());
        }

        public class MinStack
        {
            Stack<int> stack;
            int min = int.MaxValue;

            /** initialize your data structure here. */
            public MinStack()
            {
                stack = new Stack<int>();
            }

            public void Push(int x)
            {
                stack.Push(x);
                if (x < min)
                {
                    min = x;
                }
            }

            public void Pop()
            {
                int x = stack.Pop();
                if (x == min)
                {
                    min = int.MaxValue;
                    foreach (int i in stack)
                    {
                        if (i < min)
                        {
                            min = i;
                        }
                    }
                }
            }

            public int Top()
            {
                return stack.Peek();
            }

            public int GetMin()
            {
                return min;
            }
        }
    }

}
