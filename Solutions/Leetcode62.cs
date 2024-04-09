namespace LeetcodeSharp.Solutions; 
public class Leetcode62 {
    public int UniquePaths(int m, int n) {
        int[][] mat = new int[m][];
        for (int i = 0; i < m; i++) {
            mat[i] = new int[n];
        }
        for (int i = 0; i < n; i++) {
            mat[0][i] = 1;
        }
        for (int i = 0; i < m; i++) {
            mat[i][0] = 1;
        }

        for (int i = 1; i < m; i++) {
            for (int j = 1; j < n; j++) {
                mat[i][j] = mat[i - 1][j] + mat[i][j - 1];
            }
        }
        return mat[m - 1][n - 1];
    }
}
