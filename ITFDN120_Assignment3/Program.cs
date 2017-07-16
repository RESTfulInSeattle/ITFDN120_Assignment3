using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFDN120_Assignment3
{
    class RPNStack
    {
        private int stackPointer = 1;
        private int[] stack = new int[1];

        //Push a value on top of the stack, after resizing the stack to accomodate
        public void Push(int value)
        {
            stackPointer++;
            Array.Resize(ref stack, stackPointer);
            stack[stackPointer - 1] = value;
        }

        //Pop a value from the stack, and resize the array
        public int Pop()
        {
            if (!IsEmpty())
            {
                int value = stack[stackPointer - 1];
                Array.Resize(ref stack, stackPointer - 1);
                stackPointer--;
                return value;
            }
            return 0;
        }

        //Return the top value on the stack
        public int Top()
        {
            if (!IsEmpty())
            {
                return stack[stackPointer - 1];
            }
            return 0;
        }

        //If stack pointer is 0, it is empty
        public bool IsEmpty()
        {
            if (stackPointer == 1) return true;
            return false;
        }
    }
    
    class RPN
    {
        private string[] operators = { "+", "-", "*", "/" };
        private RPNStack stack = new RPNStack();

        //if input is a number, pushes it onto the stack, if it's an operator, it performs the operation
        public void Process(string input)
        {
            bool isOperator = false;
            int result = 0;

            for(int i = 0; i < operators.Length; i++)
            {
                if (operators[i] == input) isOperator = true;
            }

            if(isOperator)
            {
                int num1 = stack.Pop();
                int num2 = stack.Pop();

                switch(input)
                {
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
                stack.Push(result);
                return;
            }

            stack.Push(int.Parse(input));
            return;
        }

        //returns the top value on the stack
        public int Result()
        {
            return stack.Top();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            RPN rpn = new RPN();
            bool stop = false;
            string input;

            while (!stop)
            {
                input = Console.ReadLine();
                if (input.Length == 0) stop = true;
                else
                {
                    rpn.Process(input);
                    Console.WriteLine("=" + rpn.Result());
                }
            }
        }
    }
}
