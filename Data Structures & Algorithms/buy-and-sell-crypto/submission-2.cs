public class Solution {
    public int MaxProfit(int[] prices) {
            int totalDays = prices.Length;
            int buy = int.MaxValue, sell = 0;

            int i = 0;
            while(i < totalDays)
            {
                // skip to the next day until the price is lower than the current buy price
                if (prices[i] < buy)
                {
                    buy = prices[i];
                    i++;
                    continue;
                }

                // if it reached here, we assume that the price is higher than the current buy price, so we can sell
                var diff = prices[i] - buy;
                sell = Math.Max(sell, diff);
                i++;
            }
            return sell;

    }
}
