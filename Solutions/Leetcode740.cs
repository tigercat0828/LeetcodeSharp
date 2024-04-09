// Delete and Earn 
namespace LeetcodeSharp.Solutions {
    public class Leetcode740 {
        public int DeleteAndEarn(int[] nums) {
            // think like house robber
            int maximum = nums.Max();

            int[] prices = new int[maximum + 1];

            for (int i = 0; i < nums.Length; i++) {
                prices[nums[i]] += nums[i];
            }
            int[] DP = new int[maximum + 1];
            DP[0] = prices[0];
            DP[1] = Math.Max(prices[0], prices[1]);
            for (int i = 2; i <= maximum; i++) {
                DP[i] = Math.Max(
                    DP[i - 1],
                    DP[i - 2] + prices[i]);
            }
            return DP[maximum];
        }
    }

}

