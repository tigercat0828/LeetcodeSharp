namespace LeetcodeSharp.Solutions;
public class Leetcode3 {
    // time O(n)
    // space O(256) = O(1)
    public int LengthOfLongestSubstring(string s) {
        // corner case
        if (string.IsNullOrEmpty(s)) return 0;
        if (s.Length == 1) return 1;

        Dictionary<char, int> dict = [];
        int start = 0;
        int result = 0;
        for (int i = 0; i < s.Length; i++) {
            if (dict.ContainsKey(s[i])) {
                dict[s[i]]++;
            }
            else {
                dict[s[i]] = 1;
            }
            while (dict[s[i]] > 1) {
                dict[s[start]]--;
                start++;
            }
            result = Math.Max(result, i - start + 1);
        }
        return result;
    }

    // O(n^2) optimize Brute Force
    public int LengthOfLongestSubstring2(string s) {
        if (string.IsNullOrEmpty(s)) return 0;
        if (s.Length == 1) return 1;


        int i = 0;
        Dictionary<char, int> dict = new();
        int subAns = 0;
        int result = 0;
        while (i < s.Length) {
            if (!dict.ContainsKey(s[i])) {
                dict.Add(s[i], i);
                subAns++;
                i++;
            }
            else {
                i = dict[s[i]] + 1;
                result = Math.Max(result, subAns);
                dict.Clear();
                subAns = 0;
            }
        }
        result = Math.Max(result, subAns);
        return result;
    }

}
