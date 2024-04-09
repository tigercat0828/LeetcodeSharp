namespace LeetcodeSharp.Solutions {
    // O(n)
    public class P1779_Find_Nearest_Point_That_Has_the_Same_X_or_Y_Coordinate {
        public int NearestValidPoint(int x, int y, int[][] points) {
            int min = int.MaxValue;
            int index = -1;
            for (int i = 0; i < points.Length; i++) {
                int tx = points[i][0];
                int ty = points[i][1];
                if (x == tx && Math.Abs(y - ty) < min) {
                    min = Math.Abs(y - ty);
                    index = i;
                }
                if (y == ty && Math.Abs(x - tx) < min) {
                    min = Math.Abs(x - tx);
                    index = i;
                }
            }
            return index;
        }
    }
}
