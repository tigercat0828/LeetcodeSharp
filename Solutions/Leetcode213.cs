// House Robber II
namespace Leetcode.CSharp.Solutions {
    public class Leetcode213 {
        int[][] memo;
        int[] nums;
        public int Rob(int[] nums) {
            int n = nums.Length;
            if (n == 1) return nums[0];
            if (n == 2) return Math.Max(nums[0], nums[1]);
            if (n == 3) return nums.Max();

            int[] DP1 = new int[n]; // deal with 0 ~ n-2
            DP1[0] = nums[0];
            DP1[1] = Math.Max(nums[0], nums[1]);
            for (int i = 2; i < n - 1; i++) {
                DP1[i] = Math.Max(DP1[i - 1], DP1[i - 2] + nums[i]);
            }

            int[] DP2 = new int[n]; // deal wiht 1 ~ n-1
            DP2[1] = nums[1];
            DP2[2] = Math.Max(nums[1], nums[2]);
            for (int i = 3; i < n; i++) {
                DP2[i] = Math.Max(DP2[i - 1], DP2[i - 2] + nums[i]);
            }

            return Math.Max(DP1[n - 2], DP2[n - 1]);
        }
        public int Rob2(int[] nums) {
            int size = nums.Length;
            if (size == 1) return nums[0];
            if (size == 2) return Math.Max(nums[0], nums[1]);
            // setup
            this.nums = nums;
            memo = new int[2][];
            memo[0] = new int[size];
            memo[1] = new int[size];
            Array.Fill(memo[0], -1);
            Array.Fill(memo[1], -1);

            return Math.Max(
                DP(0, size - 2),
                DP(1, size - 1)
            );
        }

        public int DP(int i, int j) {
            if (j < i) return 0;
            if (memo[i][j] != -1) return memo[i][j];
            memo[i][j] = Math.Max(
                DP(i, j - 2) + nums[j],
                DP(i, j - 1));

            return memo[i][j];
        }
    }
}
