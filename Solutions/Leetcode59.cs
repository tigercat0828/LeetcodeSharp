namespace LeetcodeSharp.Solutions {
    public class Leetcode59 {

        //  Right, Down, Left, Up
        static int[] dr = { 0, 1, 0, -1 };
        static int[] dc = { 1, 0, -1, 0 };
        public int[][] GenerateMatrix(int n) {


            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++) matrix[i] = new int[n];

            int count = n * n;

            int r = 0;
            int c = 0;
            int dir = 0;
            int current = 1;

            matrix[r][c] = 1;

            while (current != count) {
                if (r + dr[dir] >= n || c + dc[dir] >= n || r + dr[dir] < 0 || c + dc[dir] < 0 ||
                    matrix[r + dr[dir]][c + dc[dir]] > 0) {
                    // make turn
                    dir = (dir + 1) % 4;
                }
                r += dr[dir];
                c += dc[dir];


                current++;
                matrix[r][c] = current;
            }
            return matrix;
        }
    }
}
