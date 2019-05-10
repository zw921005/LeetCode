using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc232
    {
        public void Test()
        {
            MyQueue obj = new MyQueue();
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());
        }

        public class MyQueue
        {
            Stack<int> stack;
            /** Initialize your data structure here. */
            public MyQueue()
            {
                stack = new Stack<int>();
            }

            /** Push element x to the back of queue. */
            public void Push(int x)
            {
                int[] list = stack.Reverse().ToArray();
                stack.Clear();
                stack.Push(x);
                for(int i = 0; i < list.Length; i++)
                {
                    stack.Push(list[i]);
                }
            }

            /** Removes the element from in front of queue and returns that element. */
            public int Pop()
            {
                return stack.Pop();
            }

            /** Get the front element. */
            public int Peek()
            {
                return stack.Peek();
            }

            /** Returns whether the queue is empty. */
            public bool Empty()
            {
                return stack.Count() == 0;
            }
        }
    }
}
