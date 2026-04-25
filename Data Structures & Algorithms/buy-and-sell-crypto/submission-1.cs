public class Solution {
    public int MaxProfit(int[] prices) {
            int sellPrice = 0;
            int i = 0;
            //Find the lowest price to buy
            while (i + 1 < prices.Length && prices[i + 1] < prices[i])
                i++;

            int buyPrice = prices[i];
            Console.WriteLine("Buy Price: " + buyPrice + " on day: " + i);

            int j = i + 1;
            // Find the highest price to sell
            while (j < prices.Length)
            {
                if(prices[j] < buyPrice)
                {
                    buyPrice = prices[j];
                    j++;
                    continue;
                }
                var diff = prices[j] - buyPrice;
                sellPrice = Math.Max(sellPrice, diff);
                j++;
            }
            Console.WriteLine("Sell Price: " + sellPrice + " on day: " + (j - 1));
            return sellPrice;
    }
}
