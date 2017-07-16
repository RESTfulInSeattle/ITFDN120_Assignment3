# ITFDN120_Assignment3
https://canvas.uw.edu/courses/1166106/assignments

Create a Reverse Polish Notation (RPN) calculator using the Stack class.

rpn = new RPN

while (true)
{
  string str = readLineFromKeyboard( )

  rpn.process(str)

  print("=" + rpn.result( ))
}

Your process( ) function should handle "+", "-", "*", "/", and positive/negative numbers.

When process( ) gets a number, it should push the number onto the stack.

When process( ) gets an operation, it should pop two values off the stack, perform the operation, then push the result back onto the stack. 

The result( ) function should return the last value pushed on the stack.


Hint: Your process function should explicitly handle the operations and if it's not an operation, assume it's a number and push that number on the stack.

Scenario: In RPN, "5 ENTER 4 ENTER + ENTER 3 ENTER - ENTER" yields a value of 6.

Calc>5
=5
Calc>4
=4
Calc>+
=9
Calc>3
=3
Calc>-
=6
Previous Next
