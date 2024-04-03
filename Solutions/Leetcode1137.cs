namespace LeetcodeSharp.Solutions; 
public class Leetcode1137 {

    int[] memo;
    public int Tribonacci(int n) {
        memo = new int[38];
        Array.Fill(memo, -1);
        memo[0] = 0;
        memo[1] = 1;
        memo[2] = 1;
        return tri(n);
    }
    public int tri(int n) {
        if (n <= 2) return memo[n];
        if (memo[n] != -1) return memo[n];
        memo[n] = tri(n - 1) + tri(n - 2) + tri(n - 3);
        return memo[n];
    }
    public int Tribonacci2(int n) {
        int[] tri = new int[38];
        tri[0] = 0;
        tri[1] = 1;
        tri[2] = 1;
        for (int i = 3; i <= n; i++) {
            tri[i] = tri[i - 1] + tri[i - 2] + tri[i - 3];
        }
        return tri[n];
    }

}
