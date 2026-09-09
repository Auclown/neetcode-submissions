public class Solution
{
    public int FindMin(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        int left = 0;
        int right = nums.Length - 1;

        while (left < right)
        {
            int mid = left + (right - left) / 2;

            if (nums[mid] > nums[right])
            {
                left = mid + 1;
            }
            else
            {
                right = mid;
            }
        }

        return nums[left];
    }
}
