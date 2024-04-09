namespace LeetcodeSharp.Solutions {
    public class P74_Search_a_2D_Matrix {
        public bool SearchMatrix(int[][] matrix, int target) {
            // binary search
            int row = matrix.Length;
            int col = matrix[0].Length;
            int total = row * col;


            int right = matrix[0].Length - 1;
            int left = 0;

            while (left <= right) {
                int mid = left + (right - left) / 2;
                int r = mid / col;
                int c = mid % col;
                if (matrix[r][c] == target) {
                    return true;
                }
                if (matrix[r][c] > target) {
                    right = mid - 1;
                    continue;
                }
                if (matrix[r][c] < target) {
                    left = mid + 1;
                    continue;
                }
            }

            return false;
        }

    }
}