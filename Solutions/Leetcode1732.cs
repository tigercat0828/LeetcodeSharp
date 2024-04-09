namespace LeetcodeSharp.Solutions;

public class Leetcode1732 {
    public int LargestAltitude(int[] gain) {
        int altitude = 0;
        int max = int.MinValue;
        for (int i = 0; i < gain.Length; i++) {
            altitude += gain[i];
            altitude = Math.Max(max, altitude);
        }
        return max;
    }
}
