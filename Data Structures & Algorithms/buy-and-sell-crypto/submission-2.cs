public class Solution {
    public int MaxProfit(int[] prices) {
    int left = 0;
    int right = 0;
    int maxProfit = 0;

    while (right < prices.Length) {
        int profit = prices[right] - prices[left];
        maxProfit = Math.Max(maxProfit, profit);
        if (profit < 0) {
            left++;
        }
        else {
            right++;
        }
    }

    return maxProfit;
    }
}
