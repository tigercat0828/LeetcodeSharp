namespace LeetcodeSharp.Solutions {
    public class Leetcode746 {

        private int[] memo;
        private int[] cost;
        // DP botton-up approach
        public int MinCostClimbingStairs(int[] cost) {
            int n = cost.Length;
            int[] dp = new int[n + 1];
            dp[0] = 0;
            dp[1] = 0;
            for (int i = 2; i <= cost.Length; i++) {
                dp[i] = Math.Min(
                    dp[i - 1] + cost[i - 1],
                    dp[i - 2] + cost[i - 2]);
            }
            return dp[n];
        }
        // DP top-down approach 
        public int MinCostClimbingStairs2(int[] cost) {

            this.cost = cost;
            int n = cost.Length;
            memo = new int[n];
            Array.Fill(memo, int.MaxValue);
            memo[0] = 0;
            memo[1] = 0;
            return Math.Min(    // call h(n) will out of index
                dp2(n - 1) + cost[n - 1],
                dp2(n - 2) + cost[n - 2]);
        }
        private int dp2(int n) {
            // one step
            if (memo[n] != int.MaxValue) {
                return memo[n];
            }
            // dp[i] 到第i階所需的cost
            // dp[i+1] = dp[i] + cost[i] -> 走一步

            int oneStep = dp2(n - 1) + cost[n - 1];
            int twoStep = dp2(n - 2) + cost[n - 2];
            memo[n] = Math.Min(oneStep, twoStep);
            return memo[n];
        }
    }
}
