namespace LeetcodeSharp.Solutions {

    // Largest 3-Same-Digit Number in String
    public class Leetcode2264 {
        public string LargestGoodInteger(string num) {
            string max3digit = "";
            int max = -1;
            for (int i = 0; i < num.Length - 2; i++) {
                if (num[i] == num[i + 1] && num[i + 1] == num[i + 2]) {
                    max = Math.Max(max, num[i] - '0');
                }
            }
            if (max == -1) return "";
            return new string(max.ToString()[0], 3);
        }
        public string LargestGoodInteger2(string num) {
            char last = num[0];
            int count = 1;
            int max = -1;
            for (int i = 1; i < num.Length; i++) {

                if (num[i] == last) {
                    count++;
                    if (count >= 3) {
                        max = Math.Max(max, num[i] - '0');
                    }
                }
                else {
                    count = 1;
                }
                last = num[i];
            }
            if (max == -1) return "";
            return new string(max.ToString()[0], 3);
        }
    }
}
