namespace LeetcodeSharp.Solutions {
    public class Leetcode520 {


        // not perfect and easy to understand
        public bool DetectCapitalUse(string word) {

            int length = word.Length;
            if (length == 1) return true;
            if (length == 2) {
                if (IsUppercase(word[0]) && IsUppercase(word[1])) return true;  // AA
                if (IsUppercase(word[0]) && IsLowercase(word[1])) return true;  // Aa
                if (IsLowercase(word[0]) && IsLowercase(word[1])) return true;  // aa
            }
            if (IsLowercase(word[0]) && IsUppercase(word[1])) return false;     // aA always false

            if (IsLowercase(word[1])) { // abcd... or Abcd...
                for (int i = 2; i < length; i++) {
                    if (IsUppercase(word[i])) return false;
                }
                return true;
            }
            if (IsUppercase(word[1])) { // ABCD...
                for (int i = 2; i < length; i++) {
                    if (IsLowercase(word[i])) return false;
                }
                return true;
            }
            return false;
        }
        private bool IsUppercase(char c) {
            int ASCII = c;
            return ASCII >= 65 && ASCII <= 90;
        }
        private bool IsLowercase(char c) {
            int ASCII = c;
            return ASCII >= 97 && ASCII <= 122;
        }
    }
}
