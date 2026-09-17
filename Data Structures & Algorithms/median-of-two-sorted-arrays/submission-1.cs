public class Solution
{
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        if (nums1.Length > nums2.Length)
        {
            return FindMedianSortedArrays(nums2, nums1);
        }

        double result = 0.0;
        int m = nums1.Length;
        int n = nums2.Length;
        int low = 0;
        int high = m;
        int half = (m + n + 1) / 2;

        while (low <= high)
        {
            int i = (low + high) / 2;
            int j = half - i;

            int maxLeft1  = (i == 0) ? int.MinValue : nums1[i - 1];
            int minRight1 = (i == m) ? int.MaxValue : nums1[i];

            int maxLeft2  = (j == 0) ? int.MinValue : nums2[j - 1];
            int minRight2 = (j == n) ? int.MaxValue : nums2[j];

            if (maxLeft1 <= minRight2 && maxLeft2 <= minRight1)
            {
                if ((m + n) % 2 != 0)
                {
                    // Odd total: Left side holds the single middle element
                    return Math.Max(maxLeft1, maxLeft2);
                }
                else
                {
                    // Even total: Average the boundary elements
                    return (Math.Max(maxLeft1, maxLeft2) + Math.Min(minRight1, minRight2)) / 2.0;
                }
            }
            else if (maxLeft1 > minRight2)
            {
                high = i - 1;
            }
            else
            {
                low = i + 1;
            }
        }

        return 0.0;
    }
}
