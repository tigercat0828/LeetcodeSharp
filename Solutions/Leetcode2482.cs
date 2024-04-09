namespace LeetcodeSharp.Solutions;
public class Leetcode2482 {
    public int[][] OnesMinusZeros(int[][] grid) {
        int rows = grid.Length;
        int cols = grid[0].Length;

        int[] onesRows = new int[rows];
        int[] zerosRows = new int[rows];
        int[] onesCols = new int[cols];
        int[] zerosCols = new int[cols];

        int[][] diff = new int[rows][];
        for (int i = 0; i < rows; i++) {
            diff[i] = new int[cols];
        }
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] > 0) {
                    onesRows[i]++;
                    onesCols[j]++;
                }
            }
        }
        for (int i = 0; i < rows; i++) {
            zerosRows[i] = cols - onesRows[i];
        }
        for (int i = 0; i < cols; i++) {
            zerosCols[i] = rows - onesCols[i];
        }
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                diff[i][j] = onesRows[i] + onesCols[j] - zerosRows[i] - zerosCols[j];
            }
        }
        return diff;
    }
}
