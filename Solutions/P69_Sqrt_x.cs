namespace LeetcodeSharp.Solutions {
    public class P69_Sqrt_x {
        // Binary Search O(logx)
        public int MySqrt(int x) {
            if (x == 0 || x == 1) return x;

            int left = 1;
            int right = x / 2;
            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (mid == x / mid) {
                    return mid;
                }
                if (mid > x / mid) {
                    right = mid - 1;
                }
                else {
                    left = mid + 1;
                }
            }
            return Math.Min(left, right);
        }
        // Newton Method
        public int MySqrt2(int x) {

            return 0;
        }
    }
}
