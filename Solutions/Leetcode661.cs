namespace LeetcodeSharp.Solutions;
public class Leetcode661 {
    int[][] input;
    int row;
    int col;
    public int[][] ImageSmoother(int[][] img) {
        input = img;
        row = img.Length;
        col = img[0].Length;
        int[][] output = new int[row][];
        for (int i = 0; i < row; i++) {
            output[i] = new int[col];
            for (int j = 0; j < col; j++) {
                output[i][j] = SmoothFiter(i, j);
            }
        }
        return output;
    }
    private int SmoothFiter(int r, int c) {
        int count = 0;
        int sum = 0;
        for (int i = r - 1; i <= r + 1; i++) {
            for (int j = c - 1; j <= c + 1; j++) {
                if (i >= 0 && j >= 0 && i < row && j < col) {
                    sum += input[i][j];
                    count++;
                }
            }
        }
        return sum / count;
    }
}
