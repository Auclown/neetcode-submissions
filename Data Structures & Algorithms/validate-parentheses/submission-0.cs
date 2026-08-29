public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0)
        {
            return false;
        }

        Stack<char> stack = new Stack<char>();
        // Closing bracket as the key
        Dictionary<char, char> pairs = new Dictionary<char, char>
        {
            { ')', '(' },
            { ']', '[' },
            { '}', '{' }
        };

        foreach (char c in s)
        {
            // Check if it's a closing bracket
            if (pairs.ContainsKey(c))
            {

                if (stack.Count == 0 || stack.Pop() != pairs[c])
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;
    }
}
