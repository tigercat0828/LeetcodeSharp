namespace LeetcodeSharp.Solutions {
    public class Leetcode1254 {
        int[][] grid;
        int cols;
        int rows;
        int islandCount = 0;
        enum Type {
            Island, Water, Land, Went
        }
        public int ClosedIsland(int[][] grid) {
            Init(grid);
            FindLand();

            DrawGrid();
            // find island ...
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {
                    if (grid[i][j] == 0) islandCount++;
                    Flood(Type.Went, i, j);
                }
            }
            DrawGrid();
            return islandCount;
        }
        private void Init(int[][] grid) {
            this.grid = grid;
            cols = grid[0].Length;
            rows = grid.Length;
        }

        private void FindLand() {
            for (int i = 0; i < cols; i++) {
                if (grid[0][i] == 0) Flood(Type.Land, 0, i);
                if (grid[rows - 1][i] == 0) Flood(Type.Land, rows - 1, i);
            }
            for (int i = 0; i < rows; i++) {
                if (grid[0][i] == 0) Flood(Type.Land, i, 0);
                if (grid[rows - 1][i] == 0) Flood(Type.Land, i, cols - 1);
            }
        }

        private void Flood(Type type, int row, int col) {
            if (row < 0 || col < 0 || row >= rows || col >= cols) return;
            if (grid[row][col] > 0) return;
            grid[row][col] = (int)type;
            Flood(type, row + 1, col);
            Flood(type, row, col - 1);
            Flood(type, row - 1, col);
            Flood(type, row, col + 1);
        }
        private void DrawGrid() {
            for (int i = 0; i < rows; i++) {
                Console.WriteLine("[ " + string.Join(", ", grid[i]) + " ]");
            }
            Console.WriteLine("===========");
        }
    }
}
