namespace LeetcodeSharp.Solutions {
    public class P542_01_Matrix {
        int row;
        int col;
        public int[][] UpdateMatrix(int[][] mat) {
            row = mat.Length;
            col = mat[0].Length;
            const int UNDEF = 20000; // out of index
                                     // ⇘ 
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    if (mat[i][j] == 0) continue;
                    int top = UNDEF;
                    int right = UNDEF;
                    if (IsValid(i - 1, j)) top = mat[i - 1][j];
                    if (IsValid(i, j - 1)) right = mat[i][j - 1];
                    mat[i][j] = Math.Min(top, right) + 1;
                }
            }
            // ⇖
            for (int i = row - 1; i >= 0; i--) {
                for (int j = col - 1; j >= 0; j--) {
                    if (mat[i][j] == 0) continue;
                    int buttom = UNDEF;
                    int left = UNDEF;
                    if (IsValid(i + 1, j)) buttom = mat[i + 1][j];
                    if (IsValid(i, j + 1)) left = mat[i][j + 1];
                    mat[i][j] = Math.Min(mat[i][j], Math.Min(left, buttom) + 1);
                }
            }
            return mat;
        }
        bool IsValid(int r, int c) {
            if (r < 0 || r >= row) return false;
            if (c < 0 || c >= col) return false;
            return true;
        }
    }
}

