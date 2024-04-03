namespace LeetcodeSharp.Solutions;
public class Leetcode121 {

    // Brute force O(n^2)
    public int MaxProfit(int[] prices) {
        int minPrice = int.MaxValue;
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++) {
            if (prices[i] < minPrice) {
                minPrice = prices[i];
            }
            else if (prices[i] - minPrice > maxProfit) {
                maxProfit = prices[i] - minPrice;
            }
        }
        return maxProfit;
    }
    public int MaxProfit2(int[] prices) {
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++) {
            for (int j = i + 1; j < prices.Length; j++) {
                int tmp = prices[j] - prices[i];
                if (tmp > maxProfit) {
                    maxProfit = tmp;
                }
            }
        }
        return maxProfit;
    }
}
