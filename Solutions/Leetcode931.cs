namespace LeetcodeSharp.Solutions;

public class Leetcode931 {
    const int MAX_COST = 10000000;
    public int MinFallingPathSum(int[][] matrix) {
        int row = matrix.Length;
        int col = matrix[0].Length;
        int[][] DP = new int[row][];
        for (int i = 0; i < DP.Length; i++) {
            DP[i] = new int[col + 2];
        }
        for (int i = 0; i < DP.Length; i++) {
            DP[i][0] = MAX_COST;
            DP[i][col + 1] = MAX_COST;
        }
        for (int i = 0; i < col; i++) {
            DP[0][i + 1] = matrix[0][i];
        }
        for (int i = 1; i < row; i++) {
            for (int j = 1; j < col + 1; j++) {

                int left = DP[i - 1][j - 1];
                int mid = DP[i - 1][j];
                int right = DP[i - 1][j + 1];

                DP[i][j] = Min(left, mid, right) + matrix[i][j - 1];
            }
        }
        return DP[row - 1].Min();
    }
    private int Min(int x, int y, int z) {
        return Math.Min(x, Math.Min(y, z));
    }
}


/*
X123X
XOOOX
XOOOX 
 */