namespace LeetcodeSharp.Solutions {
    public class P994_Rotting_Oranges {
        Vec2[] dirs = new Vec2[] {
            new Vec2(0,1),
            new Vec2(0,-1),
            new Vec2(1,0),
            new Vec2(-1,0),
        };

        class Vec2 {
            public int r;
            public int c;
            public Vec2(int r, int c) {
                this.r = r;
                this.c = c;
            }
            public static Vec2 operator +(Vec2 lhs, Vec2 rhs) {
                return new Vec2(lhs.r + rhs.r, lhs.c + rhs.c);
            }
        }
        enum Orange {
            Empty, Fresh, Rotten
        }
        int row;
        int col;
        public int OrangesRotting(int[][] grid) {
            row = grid.Length;
            col = grid[0].Length;
            // build visited table
            bool[][] visited = new bool[row][];
            for (int i = 0; i < row; i++) {
                visited[i] = new bool[col];
            }
            // init rotten queue for BFS
            int freshCount = 0;
            Queue<Vec2> rottens = new Queue<Vec2>();
            for (int i = 0; i < row; i++) {
                for (int j = 0; j < col; j++) {
                    if (grid[i][j] == (int)Orange.Empty) {
                        visited[i][j] = true;
                    }
                    if (grid[i][j] == (int)Orange.Rotten) {
                        visited[i][j] = true;
                        rottens.Enqueue(new Vec2(i, j));
                    }
                    if (grid[i][j] == (int)Orange.Fresh) {
                        freshCount++;
                    }
                }
            }
            // no fresh orange, trivial answer
            if (freshCount == 0) return 0;


            int minute = -1;
            while (rottens.Count > 0) {
                minute++;
                // Console.WriteLine($"Minute {minute}");
                int count = rottens.Count;
                for (int i = 0; i < count; i++) {
                    Vec2 pop = rottens.Dequeue();
                    grid[pop.r][pop.c] = (int)Orange.Rotten;
                    // infect neighbor orange
                    for (int t = 0; t < 4; t++) {
                        Vec2 next = pop + dirs[t];
                        if (IsValidCell(next) && !visited[next.r][next.c]) {
                            visited[next.r][next.c] = true;
                            rottens.Enqueue(next);
                        }
                    }
                }
                // PrintOranges(grid);
            }

            for (int r = 0; r < row; r++) {
                for (int c = 0; c < col; c++) {
                    // if there are still fresh orange, return -1
                    if (grid[r][c] == (int)Orange.Fresh) {
                        return -1;
                    }
                }

            }
            return minute;
        }
        bool IsValidCell(Vec2 v) {
            if (v.r < 0 || v.r >= row) return false;
            if (v.c < 0 || v.c >= col) return false;
            return true;
        }


        void PrintOranges(int[][] mat) {
            for (int i = 0; i < mat.Length; i++) {
                Console.WriteLine("[" + string.Join(',', mat[i]) + "]");
            }
        }
    }
}
