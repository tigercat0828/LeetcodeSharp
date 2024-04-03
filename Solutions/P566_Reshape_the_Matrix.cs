namespace Leetcode.CSharp.Solutions {
    public class P566_Reshape_the_Matrix {
        public int[][] MatrixReshape(int[][] mat, int r, int c) {
            int row = mat.Length;
            int col = mat[0].Length;
            if (row * col != r * c) {    // illegal
                return mat;
            }
            if (row == r && col == c) { // same dimension
                return mat;
            }

            int[][] result = new int[r][];
            for (int i = 0; i < r; i++) {
                result[i] = new int[c];
            }
            int index = 0;
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    int nr = index / c;
                    int nc = index % c;
                    result[nr][nc] = mat[i][j];
                    index++;
                }
            }

            return result;
        }
    }

}
