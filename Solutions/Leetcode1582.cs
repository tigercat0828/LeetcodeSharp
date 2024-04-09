//using ElementPos = (int r, int c); // .net 8
namespace LeetcodeSharp.Solutions;
public class Leetcode1582 {
    struct ElementPos {
        public int r;
        public int c;
        public ElementPos(int r, int c) {
            this.r = r;
            this.c = c;
        }
    }
    public int NumSpecial(int[][] mat) {
        int rows = mat.Length;
        int cols = mat[0].Length;
        int[] rowCount = new int[rows];
        int[] colCount = new int[cols];
        List<ElementPos> positions = new();
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (mat[i][j] > 0) {
                    positions.Add(new ElementPos(i, j));
                    rowCount[i]++;
                    colCount[j]++;
                }
            }
        }
        int ans = 0;
        foreach (var pos in positions) {
            int r = pos.r;
            int c = pos.c;
            if (rowCount[r] < 2 && colCount[c] < 2) ans++;
        }
        return ans;
    }

    public int NumSpecial2(int[][] mat) { // for .net 8 later
        int rows = mat.Length;
        int cols = mat[0].Length;
        int[] rowCount = new int[rows];
        int[] colCount = new int[cols];
        List<ElementPos> positions = [];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (mat[i][j] > 0) {
                    positions.Add(new ElementPos(i, j));
                    rowCount[i]++;
                    colCount[j]++;
                }
            }
        }
        int ans = 0;
        foreach (var pos in positions) {
            int r = pos.r;
            int c = pos.c;
            if (rowCount[r] < 2 && colCount[c] < 2) ans++;
        }

        return ans;
    }

}
