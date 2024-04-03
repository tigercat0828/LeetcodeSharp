namespace Leetcode.CSharp.Solutions {
    public class P733_Flood_Fill {

        int[] dx = new int[] { 1, 0, -1, 0 };
        int[] dy = new int[] { 0, -1, 0, 1 };
        int row;
        int col;
        // DFS
        public int[][] FloodFill(int[][] image, int sr, int sc, int newColor) {
            row = image.Length;
            col = image[0].Length;
            int oldColor = image[sr][sc];
            if (newColor == oldColor) return image;
            Stack<(int, int)> queue = new Stack<(int, int)>();
            queue.Push((sr, sc));
            while (queue.Count > 0) {
                var (r, c) = queue.Pop();
                image[r][c] = newColor;

                for (int i = 0; i < 4; i++) {
                    var (nr, nc) = (r + dx[i], c + dy[i]);
                    if (IsVaiidPixel(nr, nc) && image[nr][nc] == oldColor) {
                        queue.Push((nr, nc));
                    }
                }
            }
            return image;
        }
        // BFS O(mn)
        public int[][] FloodFill2(int[][] image, int sr, int sc, int newColor) {

            row = image.Length;
            col = image[0].Length;
            int oldColor = image[sr][sc];
            if (newColor == oldColor) return image;
            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((sr, sc));
            while (queue.Count > 0) {
                var (r, c) = queue.Dequeue();
                image[r][c] = newColor;

                for (int i = 0; i < 4; i++) {
                    var (nr, nc) = (r + dx[i], c + dy[i]);
                    if (IsVaiidPixel(nr, nc) && image[nr][nc] == oldColor) {
                        queue.Enqueue((nr, nc));
                    }
                }
            }
            return image;
        }
        bool IsVaiidPixel(int r, int c) {
            if (r < 0 || r >= row) return false;
            if (c < 0 || c >= col) return false;
            return true;
        }
    }
}
