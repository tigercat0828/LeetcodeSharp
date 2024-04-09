namespace LeetcodeSharp.Solutions {
    public class Leetcode1287 {
        public int FindSpecialInteger(int[] arr) {

            int length = arr.Length;
            if (length == 1) return arr[0];
            int count = 1;
            for (int i = 0; i < length - 1; i++) {
                if (arr[i] != arr[i + 1]) {
                    count = 1;
                }
                else {
                    count++;
                }
                if (count / (float)length > 0.25) {
                    return arr[i];
                }
            }
            return -1;  // error
        }
    }
}
