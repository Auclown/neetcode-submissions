public class Solution 
{
    public int EvalRPN(string[] tokens) 
    {
        Stack<int> stack = new Stack<int>();

        foreach (string token in tokens) 
        {
            switch (token) 
            {
                case "+":
                    stack.Push(stack.Pop() + stack.Pop());
                    break;
                case "-":
                {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    stack.Push(a - b);
                    break;
                }
                case "*":
                    stack.Push(stack.Pop() * stack.Pop());
                    break;
                case "/":
                {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    stack.Push(a / b);
                    break;
                }
                default:
                    // If it's not an operator, it's an integer operand
                    stack.Push(int.Parse(token));
                    break;
            }
        }

        return stack.Pop();
    }
}