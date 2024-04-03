namespace Leetcode.CSharp.Solutions {
    public class Leetcode1232 { // Check If It Is a Straight Line

        public bool CheckStraightLine(int[][] coordinates) {
            if (coordinates.Length == 2) return true;

            double dx = coordinates[0][0] - coordinates[coordinates.Length - 1][0];
            double dy = coordinates[0][1] - coordinates[coordinates.Length - 1][1];
            // vertical line 
            if (dx == 0) {
                int x = coordinates[0][0];
                for (int i = 1; i < coordinates.Length; i++) {
                    if (coordinates[i][0] != x) return false;
                }
                return true;
            }
            // Point oblique type
            Func<double, double> func = (x) => dy / dx * (x - coordinates[0][0]) + coordinates[0][1];
            for (int i = 1; i < coordinates.Length - 1; i++) {
                double tx = coordinates[i][0];
                double ty = coordinates[i][1];
                if (ty != func(tx)) return false;
            }
            return true;
        }
    }
}
