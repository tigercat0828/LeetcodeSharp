namespace LeetcodeSharp.Solutions;
public class Leetcode1496 {
    struct Point {
        int x;
        int y;
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
        public static Point operator +(Point left, Point right) {
            return new Point(left.x + right.x, left.y + right.y);
        }
    }
    static Point East = new Point(1, 0);
    static Point West = new Point(-1, 0);
    static Point South = new Point(0, -1);
    static Point North = new Point(0, 1);
    static Point Origin = new Point(0, 0);
    public bool IsPathCrossing(string path) {
        HashSet<Point> points = new();
        Point current = Origin;
        points.Add(current);
        for (int i = 0; i < path.Length; i++) {
            char direction = path[i];
            switch (direction) {
                case 'E':
                    current += East; break;
                case 'W':
                    current += West; break;
                case 'S':
                    current += South; break;
                case 'N':
                    current += North; break;
            }
            if (points.Contains(current)) {
                return true;
            }
            points.Add(current);
        }
        return default;
    }
}
