namespace LeetcodeSharp.Solutions {
    public class Leetcode695 {
        private readonly int[] dx = [0, 1, 0, -1];
        private readonly int[] dy = [1, 0, -1, 0];

        int row;
        int col;
        public int MaxAreaOfIsland(int[][] grid) {
            row = grid.Length;
            col = grid[0].Length;
            int maxArea = 0;
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    if (grid[i][j] == 1) {
                        maxArea = Math.Max(maxArea, CalcArea(grid, i, j));
                    }
                }
            }
            return maxArea;
        }

        private int CalcArea(int[][] grid, int sr, int sc) {
            int area = 1;
            Stack<(int, int)> stack = [];
            grid[sr][sc] = -1;
            stack.Push((sr, sc));

            while (stack.Count > 0) {
                var (r, c) = stack.Pop();
                for (int i = 0; i < 4; i++) {
                    var (nr, nc) = (r + dx[i], c + dy[i]);
                    if (IsValidCell(nr, nc) && grid[nr][nc] == 1) {
                        grid[nr][nc] = -1;
                        area++;
                        stack.Push((nr, nc));
                    }
                }
            }
            return area;
        }
        bool IsValidCell(int x, int y) {
            if (x < 0 || x >= row) return false;
            if (y < 0 || y >= col) return false;
            return true;
        }

    }
}
