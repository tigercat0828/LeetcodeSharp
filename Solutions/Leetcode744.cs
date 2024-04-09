namespace LeetcodeSharp.Solutions {
    public class Leetcode744 {
        public class Solution {
            public char NextGreatestLetter(char[] letters, char target) {
                for (int i = 0; i < letters.Length; i++) {

                    if (target < letters[i]) {
                        return letters[i];
                    }
                }
                return letters[0];
            }
        }
    }
}
