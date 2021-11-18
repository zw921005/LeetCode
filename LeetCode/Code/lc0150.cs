using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Code
{
  public  class lc150
    {
        public int EvalRPN(string[] tokens)
        {
            string[] fuhao = new string[] { "+", "-", "*", "/" };
            Stack<string> stack = new Stack<string>();

            for (int i = 0; i < tokens.Length; i++) {
                if (fuhao.Contains(tokens[i])) {
                    int num1 = Convert.ToInt32(stack.Pop());
                    int num2 = Convert.ToInt32(stack.Pop());
                    int result = 0;
                    switch (tokens[i]) {
                        case "+":
                            result = num2 + num1;
                            break;
                        case "-":
                            result = num2 - num1;
                            break;
                        case "*":
                            result = num2 * num1;
                            break;
                        case "/":
                            result = num2 / num1;
                            break;
                    }
                    stack.Push(result.ToString());
                }
                else {
                    stack.Push(tokens[i]);
                }
            }

            return Convert.ToInt32(stack.Peek());
        }
    }
}
