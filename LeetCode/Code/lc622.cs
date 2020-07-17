using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
    /// <summary>
    /// 设计循环队列
    /// </summary>
    class MyCircularQueue
    {
        private int[] array;
        private int head;
        private int tail;
        private int size;

        /** Initialize your data structure here. Set the size of the queue to be k. */
        public MyCircularQueue(int k)
        {
            array = new int[k];
            head = 0;
            tail = 0;
            size = 0;
        }

        /** Insert an element into the circular queue. Return true if the operation is successful. */
        public bool EnQueue(int value)
        {
            if (IsFull()) return false;

            array[tail] = value;
            tail = (tail + 1) % array.Length;
            size++;
            return true;
        }

        /** Delete an element from the circular queue. Return true if the operation is successful. */
        public bool DeQueue()
        {
            if (IsEmpty()) return false;

            int result = array[head];
            head = (head + 1) % array.Length;
            size--;
            return true;
        }

        /** Get the front item from the queue. */
        public int Front()
        {
            if (IsEmpty()) return -1;
            return array[head];
        }

        /** Get the last item from the queue. */
        public int Rear()
        {
            if (IsEmpty()) return -1;
            return array[(tail + array.Length - 1) % array.Length];
        }

        /** Checks whether the circular queue is empty or not. */
        public bool IsEmpty()
        {
            return size == 0;
        }

        /** Checks whether the circular queue is full or not. */
        public bool IsFull()
        {
            return size == array.Length;
        }
    }
}
