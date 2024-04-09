namespace LeetcodeSharp.Solutions {
    public class Leetcode389 {
        public char FindTheDifference(string s, string t) {
            int[] dictS = new int[26];
            int[] dictT = new int[26];
            int i;
            for (i = 0; i < s.Length; i++) {
                dictS[s[i] - 'a']++;
                dictT[t[i] - 'a']++;
            }
            dictT[t[i] - 'a']++;

            for (int j = 0; j < 26; j++) {
                if (dictS[j] != dictT[j]) {
                    return (char)(j + 'a');
                }
            }
            return '*'; // s & t are same string
        }
    }
}
