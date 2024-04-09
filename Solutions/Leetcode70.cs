namespace LeetcodeSharp.Solutions;
public class Leetcode70 {
    // F[n]=F[n-1]+F[n-2]
    // 因為一次可以爬1、2 step,
    // 所以到達第n階的前一步可能是n-1階、n-2階
    // => 到n階的方法數 = n-1階方法數 + n-2階方法數
    // iterative
    public int ClimbStairs(int n) {
        if (n <= 3) return n;
        int A = 2;    // N2
        int B = 3;    // N3
        int C = 0;
        for (int i = 4; i <= n; i++) {
            C = A + B;
            A = B;
            B = C;
        }
        return C;
    }
    // DP bottom-up recursive with memo
    int[] memo = new int[46];
    public int ClimbStarirs2(int n) {
        Array.Fill(memo, -1);
        memo[0] = 0;
        memo[1] = 1;
        memo[2] = 2;
        memo[3] = 3;
        return climb(n);
    }
    public int climb(int n) {

        if (n <= 3) return n;
        if (memo[n] != -1) return memo[n];
        memo[n] = climb(n - 1) + climb(n - 2);
        return memo[n];
    }
}
