namespace Leetcode.CSharp.Solutions;
public class Leetcode1051 {
    public int HeightChecker(int[] heights) {
        int fault = 0;

        int len = heights.Length;
        int[] tmp = new int[heights.Length];
        Array.Copy(heights, tmp, len);
        Array.Sort(tmp);
        for (int i = 0; i < len; i++) {
            if (tmp[i] != heights[i]) {
                fault++;
            }
        }

        return fault;
    }
}
