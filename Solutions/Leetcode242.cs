namespace Leetcode.CSharp.Solutions {
    public class Leetcode242 {
        // O(n)
        public bool IsAnagram(string s, string t) {
            int[] charDictS = new int[26];
            int[] charDictT = new int[26];
            foreach (char ch in s) {
                charDictS[ch - 'a']++;
            }
            foreach (char ch in t) {
                charDictT[ch - 'a']++;
            }
            for (int i = 0; i < 26; i++) {

                if (charDictT[i] != charDictS[i]) {
                    return false;
                }
            }
            return true;
        }
    }
}
