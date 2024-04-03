namespace Leetcode.CSharp.Solutions {
    public class Leetcode509 {
        // iterative | space O(1), time O(n)
        public int Fib2(int n) {
            if (n == 0 || n == 1) return n;
            int a = 0;
            int b = 1;
            int c = 0;
            for (int i = 1; i < n; i++) {
                c = a + b;
                b = c;
                a = b;
            }
            return c;
        }
        // recursion with memory space | space O(n), time O(1)
        int[] memo = new int[31];
        public int Fib(int n) {
            Array.Fill(memo, -1);
            memo[0] = 0;
            memo[1] = 1;
            return fib(n);
        }
        public int fib(int n) {
            if (n == 0 || n == 1) return memo[n];
            if (memo[n] != -1) return memo[n];
            memo[n] = fib(n - 1) + fib(n - 2);
            return memo[n];
        }
    }
}
