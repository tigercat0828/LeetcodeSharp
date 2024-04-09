namespace LeetcodeSharp.Solutions {
    public class P383_Ransom_Note {
        // O(n)
        public bool CanConstruct(string ransomNote, string magazine) {
            int[] dictRasom = new int[26];
            int[] dictMagzine = new int[26];
            for (int i = 0; i < ransomNote.Length; i++) {
                int key = ransomNote[i] - 'a';
                dictRasom[key]++;
            }
            for (int i = 0; i < magazine.Length; i++) {
                int key = magazine[i] - 'a';
                dictMagzine[key]++;
            }
            for (int i = 0; i < 26; i++) {
                if (dictRasom[i] > dictMagzine[i]) {
                    return false;
                }
            }
            return true;
        }
    }
}
