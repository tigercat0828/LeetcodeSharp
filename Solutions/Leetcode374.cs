namespace LeetcodeSharp.Solutions;
public class Leetcode374 {
    public int GuessNumber(int n) {
        int left = 1;
        int right = n;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            int result = guess(mid);
            if (result == 0) {
                return mid;
            }
            if (result == 1) { // num < pick
                left = mid + 1;
                continue;
            }
            if (result == -1) { // num > pick
                right = mid - 1;
                continue;
            }
        }
        return -1;
    }
    // dummy method
    public int guess(int n) {
        return -1;
    }
}
