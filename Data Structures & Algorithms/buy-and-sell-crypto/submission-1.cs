public class Solution {
    public int MaxProfit(int[] prices) {
        int minPrice = prices[0];
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            int currentPrice = prices[i];

            if (currentPrice < minPrice)
            {
                minPrice = currentPrice;
            }
            else if (currentPrice - minPrice > maxProfit)
            {
                maxProfit = currentPrice - minPrice;
            }
        }

        return maxProfit;
    }
}
