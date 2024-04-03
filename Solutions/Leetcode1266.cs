namespace LeetcodeSharp.Solutions;
public class Leetcode1266 {
    public int MinTimeToVisitAllPoints(int[][] points) {
        int time = 0;
        for (int i = 1; i < points.Length; i++) {
            time += Goto(points[i - 1], points[i]);
        }
        return time;
    }
    public int Goto(int[] point1, int[] point2) {
        int xOffset = Math.Abs(point1[0] - point2[0]);
        int yOffset = Math.Abs(point1[1] - point2[1]);
        int diagMove = Math.Min(xOffset, yOffset);
        int gridMove = Math.Max(xOffset, yOffset) - diagMove;
        return diagMove + gridMove;
    }
}
