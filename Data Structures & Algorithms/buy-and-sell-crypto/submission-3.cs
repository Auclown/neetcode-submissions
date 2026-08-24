public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int left = 0;
        int right = 1;
        int maxProfit = 0;

        while (right < prices.Length)
        {
            if (prices[right] > prices[left])
            {
                int profit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit, profit);
            }
            else if (prices[right] <= prices[left])
            {
                left = right;
            }

            right++;
        }

        return maxProfit;
    }
}