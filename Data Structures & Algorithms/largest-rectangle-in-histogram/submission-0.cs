public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        Stack<int> stack = new Stack<int>();
        int maxArea = int.MinValue;
        int n = heights.Length;

        for (int i = 0; i < heights.Length; i++)
        {
            // Check the height of the bar at the top of the stack
            while (stack.Count > 0 && heights[i] < heights[stack.Peek()])
            {
                // 1. Pop the index of the bar whose rectangle we are resolving
                int poppedIndex = stack.Pop();
                int height = heights[poppedIndex];

                // 2. Calculate the boundaries and area for this popped bar
                int width = (stack.Count == 0) ? i : (i - stack.Peek() - 1);
                maxArea = Math.Max(maxArea, height * width);
            }

            stack.Push(i);
        }

        // Drain any bars that extended all the way to the right edge
        while (stack.Count > 0)
        {
            int poppedIndex = stack.Pop();
            int height = heights[poppedIndex];
            int width = (stack.Count == 0) ? n : (n - stack.Peek() - 1);
            maxArea = Math.Max(maxArea, height * width);
        }

        return maxArea;
    }
}
