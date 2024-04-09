using System.Text;

namespace LeetcodeSharp.Solutions;
public class Leetcode2352 {
    public int EqualPairs(int[][] grid) {
        List<string> rows = new();
        List<string> cols = new();
        int length = grid.Length;
        for (int i = 0; i < length; i++) {
            StringBuilder rsb = new();
            StringBuilder csb = new();
            for (int k = 0; k < length; k++) {
                rsb.Append(grid[i][k]);   // row
                csb.Append(grid[k][i]);   // col
            }
            rows.Add(rsb.ToString() + "-");
            cols.Add(csb.ToString() + "-");
        }
        Dictionary<string, int> dict = new();
        for (int i = 0; i < length; i++) {
            string key = rows[i];
            if (dict.ContainsKey(key)) dict[key]++;
            else dict.Add(key, 1);
        }

        int equals = 0;
        for (int i = 0; i < length; i++) {
            string key = cols[i];
            if (dict.ContainsKey(key)) {
                equals += dict[key];
            }
        }
        return equals;
    }
}
