//Range Sum Query 2D - Immutable

namespace Leetcode.CSharp.Solutions {
    public class Leetcode304 {
        class NumMatrix {
            int[][] prefixSum;
            // O(mn)
            public NumMatrix(int[][] matrix) {

                int row = matrix.Length;
                int col = matrix[0].Length;
                prefixSum = matrix;

                for (int i = 0; i < row; i++) {
                    for (int j = 1; j < col; j++) {
                        prefixSum[i][j] += prefixSum[i][j - 1];
                    }
                }

                foreach (var item in prefixSum) Console.WriteLine(string.Join(',', item));

            }
            public int SumRegion(int row1, int col1, int row2, int col2) {
                int sum = 0;
                for (int i = row1; i <= row2; i++) {
                    if (col1 == 0) sum += prefixSum[i][col2];
                    else sum += prefixSum[i][col2] - prefixSum[i][col1 - 1];
                }
                return sum;
            }
        }
    }
}
