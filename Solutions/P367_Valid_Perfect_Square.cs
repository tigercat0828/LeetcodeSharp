namespace Leetcode.CSharp.Solutions {
    public class P367_Valid_Perfect_Square {
        // binary search O(logn)
        public bool IsPerfectSquare(int num) {
            int left = 1;
            int right = num;
            int result = search(num, left, right);
            return result >= 1;

        }
        private int search(int target, int left, int right) {

            if (left <= right) {
                int mid = left + (right - left) / 2;

                if (mid == (float)target / mid) {
                    return mid;
                }
                if (mid > target / mid) {
                    return search(target, left, mid - 1);
                }
                else {
                    return search(target, mid + 1, right);
                }
            }
            return 0;
        }
        // using built-in library, bad
        public bool IsPerfectSquare2(int num) {
            int sqrt = (int)Math.Sqrt(num);
            return num == sqrt * sqrt;
        }
    }
}
