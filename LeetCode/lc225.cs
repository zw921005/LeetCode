using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc225
    {
        public void Test()
        {
            MyStack obj = new MyStack();
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());
            Console.WriteLine(obj.Pop());
        }

        public class MyStack
        {
            Queue<int> queue;
            /** Initialize your data structure here. */
            public MyStack()
            {
                queue = new Queue<int>();
            }

            /** Push element x onto stack. */
            public void Push(int x)
            {
                queue.Enqueue(x);
                int length = queue.Count();
                while (length > 1)
                {
                    queue.Enqueue(queue.Dequeue());
                    length--;
                }
            }

            /** Removes the element on top of the stack and returns that element. */
            public int Pop()
            {
                return queue.Dequeue();
            }

            /** Get the top element. */
            public int Top()
            {
                return queue.Peek();
            }

            /** Returns whether the stack is empty. */
            public bool Empty()
            {
                return queue.Count() == 0;
            }
        }
    }
}
