namespace LeetcodeSharp.Solutions {
    public class Leetcode1572 {
        // O(n)
        public int DiagonalSum(int[][] mat) {
            int sum = 0;
            int n = mat.Length;
            for (int i = 0; i < n; i++) {
                sum += mat[i][i];
                sum += mat[i][n - i - 1];
            }
            // minus the duplicate mid term
            if (n % 2 == 1) {
                int m = n / 2;
                sum -= mat[m][m];
            }
            return sum;
        }
    }
}
