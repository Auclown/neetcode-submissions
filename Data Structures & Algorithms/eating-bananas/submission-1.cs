public class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = piles.Max();
        int result = right;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            int totalHours = 0;
            foreach (int pile in piles)
            {
                totalHours += (pile + mid - 1) / mid;
            }

            if (totalHours <= h)
            {
                result = mid;
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return result;
    }
}
