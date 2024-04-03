namespace LeetcodeSharp.Solutions;
public class Leetcode387 {
    public int FirstUniqChar(string s) {
        if (string.IsNullOrEmpty(s)) {
            return -1;
        }
        int[] charDict = new int[26];
        foreach (char c in s) {
            charDict[c - 'a']++;
        }
        for (int i = 0; i < s.Length; i++) {
            if (charDict[s[i] - 'a'] == 1) {
                return i;
            }
        }
        return -1;
    }

    public int FirstUniqChar2(string s) {
        var uniqueChars = s.Distinct();
        foreach (var ch in uniqueChars) {
            if (s.Count(x => x == ch) == 1) {
                return s.IndexOf(ch);
            }
        }
        return -1;
    }

}
