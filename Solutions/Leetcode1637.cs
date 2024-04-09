namespace LeetcodeSharp.Solutions;
public class Leetcode1637 {
    public struct Point {
        public int x;
        public int y;
        public Point(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }
    private int Distance(Point A, Point B) {
        return Math.Abs(A.x - B.x);
    }
    public int MaxWidthOfVerticalArea(int[][] points) {

        List<Point> pointList = new();
        for (int i = 0; i < points.Length; i++) {
            pointList.Add(new Point(points[i][0], points[i][1]));
        }
        pointList = pointList.OrderBy(p => p.x).ToList();

        int maxWidth = int.MinValue;
        for (int i = 1; i < pointList.Count; i++) {
            int distance = Distance(pointList[i], pointList[i - 1]);
            maxWidth = Math.Max(maxWidth, distance);
        }
        return maxWidth;
    }
}
