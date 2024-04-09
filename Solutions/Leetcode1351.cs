namespace LeetcodeSharp.Solutions;
public class Leetcode1351 {

    // O(mlogn) mxn matrix
    public int CountNegatives(int[][] grid) {
        int count = 0;
        int row = grid.Length;
        int col = grid[0].Length;
        for (int i = 0; i < row; i++) {
            int index = BisearchNegativeIndex(grid[i]);
            if (index >= 0) {
                count += col - index;
            }
            Console.WriteLine($"index= {index}");
        }
        return count;
    }
    int BisearchNegativeIndex(int[] row) {
        int left = 0;
        int right = row.Length - 1;
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (row[mid] >= 0) {
                left = mid + 1;
            }
            else {
                right = mid;
            }
        }
        if (row[left] >= 0) return -1;
        return left;
    }
}
