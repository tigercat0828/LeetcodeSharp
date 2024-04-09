namespace LeetcodeSharp.Solutions {
    public class Leetcode2405 {
        // Optimal Partition of String
        public int PartitionString(string s) {
            int strCount = 1;
            HashSet<char> letters = new();
            for (int i = 0; i < s.Length; i++) {
                char c = s[i];
                if (letters.Contains(c)) {
                    strCount++;
                    letters.Clear();
                }
                letters.Add(c);
            }
            return strCount;
        }
    }
}
