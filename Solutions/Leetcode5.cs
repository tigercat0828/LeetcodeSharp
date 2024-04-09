namespace LeetcodeSharp.Solutions {
    public class Leetcode5 {
        // DP O(n^2)
        public string LongestPalindrome(string s) {
            int n = s.Length;
            bool[][] dp = new bool[n][];
            for (int t = 0; t < n; t++) {
                dp[t] = new bool[n];
            }
            for (int t = 0; t < n; t++) {
                dp[t][t] = true;
            }
            int start = 0;
            int end = 0;
            int max = 0;

            for (int j = 1; j < n; j++) {
                for (int i = 0; i < j; i++) {
                    // determin s[i..j] is a palindrome
                    if (i + 1 == j) {
                        dp[i][j] = s[i] == s[j];
                    }
                    else {
                        dp[i][j] = s[i] == s[j] && dp[i + 1][j - 1];
                    }
                    // record max
                    if (dp[i][j] == true && j - i > max) {
                        max = j - i;
                        start = i;
                        end = j;
                    }
                }
            }

            return s.Substring(start, end - start + 1);
        }
    }
}
