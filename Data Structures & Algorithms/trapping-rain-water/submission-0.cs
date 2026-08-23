public class Solution {
    public int Trap(int[] height) {
        int left = 0;
        int right = height.Length - 1;

        int leftMax = height[left];
        int rightMax = height[right];
        int total = 0;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                leftMax = Math.Max(leftMax, height[left]);
                total += leftMax - height[left];
                left++;
            }
            else if (height[right] <= height[left])
            {
                rightMax = Math.Max(rightMax, height[right]);
                total += rightMax - height[right];
                right--;
            }

        }

        return total;
    }
}
