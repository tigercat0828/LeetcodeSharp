namespace Leetcode.CSharp.Solutions {
    /*
    dp[i][j] =  { 0, i>j
                { 1, i=j
                { dp[i-1][j-1]
                { max(dp[i,j-1], dp[i+1,j]), s[i]!=s[j]
     */
    public class Leetcode516 {
        public int LongestPalindromeSubseq(string s) {
            // setup space and base case
            int n = s.Length;
            int[][] dp = new int[n][];
            for (int i = 0; i < dp.Length; i++) {
                dp[i] = new int[n];
            }
            for (int i = 0; i < dp.Length; i++) {
                dp[i][i] = 1;
            }
            int max = 1;
            // perform dp
            for (int r = 0; r < n; r++) {
                for (int c = 0; c < n - r - 1; c++) {
                    int I = c;
                    int J = c + r + 1;
                    if (s[I] != s[J]) {
                        dp[I][J] = Math.Max(dp[I + 1][J], dp[I][J - 1]);
                    }
                    else {
                        dp[I][J] = dp[I + 1][J - 1] + 2;
                    }
                    max = Math.Max(max, dp[I][J]);
                }
            }

            //for (int i = 0; i < n; i++) {
            //    for (int j = 0; j < n; j++) {
            //        if (i <= j) {
            //            Console.Write(dp[i][j] + " ");
            //        }
            //        else {
            //            Console.Write(" " + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            return max;
        }
    }
}
