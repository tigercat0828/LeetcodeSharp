namespace LeetcodeSharp.Solutions;
public class Leetcode1143 {
    public int LongestCommonSubsequence(string text1, string text2) {
        int row = text1.Length + 1;
        int col = text2.Length + 1;
        int[][] table = new int[row][];
        for (int i = 0; i < row; i++) {
            table[i] = new int[col];
        }
        for (int i = 1; i < row; i++) {
            for (int j = 1; j < col; j++) {
                if (text1[i - 1] == text2[j - 1]) {
                    table[i][j] = table[i - 1][j - 1] + 1;
                }
                else {
                    table[i][j] = Math.Max(table[i - 1][j], table[i][j - 1]);
                }
            }
        }
        return table[row - 1][col - 1];
    }
}