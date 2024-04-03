namespace Leetcode.CSharp.Solutions {
    public class Leetcode120 {
        // bottom-up (better, clean, less if-statement)
        public int MinimumTotal(IList<IList<int>> triangle) {
            for (int i = triangle.Count - 2; i >= 0; i--) {
                for (int j = triangle[i].Count - 1; j >= 0; j--) {
                    triangle[i][j] += Math.Min(triangle[i + 1][j], triangle[i + 1][j + 1]);
                }
            }
            return triangle[0][0];
        }
        // top-down
        public int MinimumTotal2(IList<IList<int>> triangle) {

            for (int i = 1; i < triangle.Count; i++) {
                int levelCount = triangle[i].Count;
                for (int j = 0; j < levelCount; j++) {
                    if (j == 0) {
                        triangle[i][j] += triangle[i - 1][j];
                    }
                    else if (j == levelCount - 1) {
                        triangle[i][j] += triangle[i - 1][j - 1];
                    }
                    else {
                        triangle[i][j] += Math.Min(triangle[i - 1][j], triangle[i - 1][j - 1]);
                    }
                }
            }
            // find minimum element in bottom 
            int ans = int.MaxValue;
            foreach (var item in triangle[triangle.Count - 1]) {
                ans = Math.Min(ans, item);
            }
            return ans;
        }
    }
}
