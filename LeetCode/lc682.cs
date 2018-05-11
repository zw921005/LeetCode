using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class lc682
    {
        public void Test()
        {
            string[] input = { "5", "2", "C", "D", "+" };//30
            Console.WriteLine(CalPoints(input));
            input = new string[] { "5", "-2", "4", "C", "D", "9", "+", "+" };//27
            Console.WriteLine(CalPoints(input));
        }

        public int CalPoints(string[] ops)
        {
            Stack<int> stack = new Stack<int>();
            foreach (string op in ops)
            {
                switch (op)
                {
                    case "+":
                        int peek1 = stack.Pop();
                        int peek2 = stack.Peek();
                        stack.Push(peek1);
                        stack.Push(peek1 + peek2);
                        break;
                    case "D":
                        stack.Push(stack.Peek() * 2);
                        break;
                    case "C":
                        stack.Pop();
                        break;
                    default:
                        stack.Push(Convert.ToInt32(op));
                        break;
                }
            }

            int sum = 0;
            while (stack.Count() != 0)
            {
                sum += stack.Pop();
            }

            return sum;
        }
    }
}
