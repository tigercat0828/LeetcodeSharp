namespace LeetcodeSharp.Solutions {
    public class P200_Number_of_Islands {
        bool[][] isVisited;
        readonly int[] dr = { 0, 0, -1, 1 }; // direciotn for row:i
        readonly int[] dc = { -1, 1, 0, 0 }; // direction for col;j
        int row;
        int col;
        public int NumIslands(char[][] grid) {
            int islandCount = 0;
            init(grid);
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    if (grid[i][j] == '1' && !isVisited[i][j]) {
                        islandCount++;
                        flow(grid, i, j);
                    }
                }
            }
            return islandCount;
        }
        private void flow(char[][] grid, int i, int j) {
            for (int t = 0; t < 4; t++) {
                int nr = i + dr[t];
                int nc = j + dc[t];
                if (nr < 0 || nc < 0 || nr >= row || nc >= col) {   // bounding check
                    continue;
                }
                if (!isVisited[nr][nc] && grid[nr][nc] == '1') {
                    isVisited[nr][nc] = true;
                    flow(grid, nr, nc);
                }
            }
        }
        private void init(char[][] grid) {
            row = grid.Length;
            col = grid[0].Length;
            isVisited = new bool[row][];
            for (int i = 0; i < row; i++) {
                isVisited[i] = new bool[col];
            }
        }
    }
}
