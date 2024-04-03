namespace LeetcodeSharp.Solutions;
public class Leetcode1239 {
    List<string> strs;
    int result = 0;
    public int MaxLength(IList<string> arr) {
        strs = arr.ToList();

        Track(0, "");

        return result;
    }
    private void Track(int start, string current) {
        if (IsUnique(current)) {
            result = Math.Max(result, current.Length);
        }
        else {
            return;
        }

        for (int t = start; t < strs.Count; t++) {
            Track(t + 1, current + strs[t]);
        }
    }
    private bool IsUnique(string s) {
        int[] freq = new int[26];
        foreach (char c in s) {
            freq[c - 'a']++;
            if (freq[c - 'a'] > 1) {
                return false;
            }
        }
        return true;
    }
}