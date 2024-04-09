namespace LeetcodeSharp.Solutions {
    public class P50_Pow_x_n {
        Dictionary<int, double> memo = new Dictionary<int, double>();
        public double MyPow(double x, int n) {
            memo = new Dictionary<int, double>();
            memo[0] = 1;
            memo[1] = x;
            memo[2] = x * x;
            helper(x, n);
            if (n < 0) {
                return 1 / memo[n];
            }
            return memo[n];
        }

        public double helper(double x, int n) {

            if (memo.ContainsKey(n)) return memo[n];
            if (n % 2 == 0) {
                memo[n] = helper(x, n / 2) * helper(x, n / 2);
            }
            else {
                memo[n] = helper(x, n / 2) * helper(x, n / 2) * x;
            }
            return memo[n];
        }

        // O(n) : Time Limit Excess
        public double MyPow2(double x, int n) {
            if (n == 0) return 1.0;
            double ans = 1.0;
            for (int i = 0; i < Math.Abs(n); i++) {
                ans *= x;
            }
            if (n < 0) {
                return 1.0 / ans;
            }
            return ans;
        }

    }
}
