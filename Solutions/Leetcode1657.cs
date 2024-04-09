namespace LeetcodeSharp.Solutions {
    public class Leetcode1657 {
        public bool CloseStrings(string word1, string word2) {
            if (word1.Length != word2.Length) return false;

            int[] letter1 = new int[26];
            int[] letter2 = new int[26];

            int length = word1.Length;
            for (int i = 0; i < length; i++) {
                letter1[word1[i] - 'a']++;
                letter2[word2[i] - 'a']++;
            }

            for (int i = 0; i < 26; i++) {
                if (letter1[i] > 0 && letter2[i] > 0) {
                    continue;
                }
                if (letter1[i] == 0 && letter2[i] == 0) {
                    continue;
                }
                return false;
            }

            List<int> sortedFreq1 = [.. letter1.Where(x => x > 0).Order()];
            List<int> sortedFreq2 = [.. letter2.Where(x => x > 0).Order()];


            for (int i = 0; i < sortedFreq1.Count; i++) {
                if (sortedFreq1[i] != sortedFreq2[i]) return false;
            }
            return true;
        }
    }
}
