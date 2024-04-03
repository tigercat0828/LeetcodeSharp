namespace Leetcode.CSharp.Solutions {
    public class P474_Ones_and_Zeroes {
        public int FindMaxForm(string[] strs, int m, int n) {
            int[][] dp = new int[m + 1][];
            for (int i = 0; i < m + 1; i++) {
                dp[i] = new int[n + 1];
            }
            for (int t = 0; t < strs.Length; t++) {
                int ones = 0;
                for (int k = 0; k < strs[t].Length; k++) {
                    if (strs[t][k] == '1') ones++;
                }
                int zeros = strs[t].Length - ones;


                for (int i = m; i > zeros - 1; i--) {
                    for (int j = n; j > ones - 1; j--) {
                        dp[i][j] = Math.Max(dp[i][j], dp[i - zeros][j - ones] + 1);
                    }
                }

            }
            return dp[m][n];
        }

    }
}
