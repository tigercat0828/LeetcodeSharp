namespace LeetcodeSharp.Solutions;
public class Leetcode1347 {
    public int MinSteps(string s, string t) {
        int[] letterS = new int[26];
        int[] letterT = new int[26];
        int length = s.Length;
        for (int i = 0; i < length; i++) {
            letterS[s[i] - 'a']++;
            letterT[t[i] - 'a']++;
        }
        int diff = 0;
        for (int i = 0; i < 26; i++) {
            diff += Math.Abs(letterS[i] - letterT[i]);
        }
        return diff / 2;
    }
}
