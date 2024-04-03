namespace Leetcode.CSharp.Solutions {
    public class P441_Arranging_Coins {
        // Math O(1)
        // n(n+1)/2 <= x
        // n^2+n <= 2x
        // n^2+n+0.25 <= 2x+0.25  (0.25 = 1/4)
        // (n+0.5)^2 <= 2x+1/4
        // n <= sqrt(2x+0.25)-0.5
        public int ArrangeCoins(int n) {
            int ans = (int)(Math.Sqrt(2 * (long)n + 0.25) + 0.5);
            return ans;
        }

        // Binary Search O(n)
        public int ArrangeCoins2(int n) {
            if (n == 0 || n == 1) return n;
            int left = 1;
            int right = (int)Math.Pow(2, 16);
            return Search(n, left, right);
        }
        private int Search(int n, int left, int right) {
            if (left <= right) {
                long mid = left + (right - left) / 2;
                long levelNeed = mid * (mid + 1) / 2;
                if (levelNeed == n) {
                    return (int)mid;
                }
                else if (levelNeed > n) {
                    return Search(n, left, (int)mid - 1);
                }
                else {
                    return Search(n, (int)mid + 1, right);
                }
            }
            return Math.Min(left, right);
        }
    }
}
