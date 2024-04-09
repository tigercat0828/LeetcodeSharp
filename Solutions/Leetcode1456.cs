namespace LeetcodeSharp.Solutions {
    public class Leetcode1456 {
        // sliding window O(n)
        public int MaxVowels(string s, int k) {

            if (k == 1) {
                for (int i = 0; i < s.Length; i++) {
                    if (IsVowel(s[i])) return 1;
                }
                return 0;
            }

            int start = 0;
            int end = k - 1;
            int current = 0;
            int max;
            for (int i = start; i <= end; i++) {
                if (IsVowel(s[i])) current++;
            }

            max = current;
            while (end != s.Length) {
                if (IsVowel(s[start])) current--;
                start++;
                end++;
                if (IsVowel(s[end])) current++;

                max = Math.Max(max, current);
            }
            // acbdefghijklmno
            return max;
        }
        private bool IsVowel(char c) {
            return c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u';
        }
    }
}
